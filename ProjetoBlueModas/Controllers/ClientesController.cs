﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProjetoBlueModas.Models;

namespace ProjetoBlueModas.Controllers {
    public class ClientesController : Controller {
        private readonly BlueModasContext _context;

        public ClientesController(BlueModasContext context) {
            _context = context;
        }

        // GET: Clientes
        public IActionResult Index() {
            return View();
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            var cliente = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null) {
                return NotFound();
            }

            return View(cliente);
        }

        // GET: Clientes/Create
        public IActionResult Create() {
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Email,Telefone")] Cliente cliente) {
            if (ModelState.IsValid) {
                var cesta = await _context.Cesta.FirstOrDefaultAsync();
                if(cesta == null) {
                    return NotFound();
                }

                cliente.Protocolo = cesta.Protocolo;
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                InserirClienteNoHistorico();
            }
            return RedirectToRoute(new { controller = "Home", action = "PedidoRealizado" });
        }

        public void InserirClienteNoHistorico() {
            var connection = @"Server=(localdb)\mssqllocaldb;Database=bluemodas;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connection)) {
                conn.Open();
                using (SqlCommand command = new SqlCommand("", conn)) {
                    command.CommandText = "UPDATE Historico SET ClienteId = C.Id, Data = CURRENT_TIMESTAMP, NomeCliente = Nome, EmailCliente = C.Email, TelefoneCliente = C.Telefone FROM Historico H INNER JOIN Clientes C ON H.Protocolo = C.Protocolo;";
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
            }
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(int? id) {
            if (id == null) {
                return NotFound();
            }

            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null) {
                return NotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Email,Telefone")] Cliente cliente) {
            if (id != cliente.Id) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                } catch (DbUpdateConcurrencyException) {
                    if (!ClienteExists(cliente.Id)) {
                        return NotFound();
                    } else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(int? id) {
            if (id == null) {
                return NotFound();
            }

            var cliente = await _context.Clientes.FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null) {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) {
            var cliente = await _context.Clientes.FindAsync(id);
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteExists(int id) {
            return _context.Clientes.Any(e => e.Id == id);
        }


    }
}
