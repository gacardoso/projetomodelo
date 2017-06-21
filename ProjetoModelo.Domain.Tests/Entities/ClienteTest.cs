﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProjetoModelo.Domain.Entities;

namespace ProjetoModelo.Domain.Tests.Entities
{
    [TestFixture]
    class ClienteTest
    {
        private Cliente _cliente;

        [Test]
        public void NaoDeveAceitarClienteComCPFInvalido()
        {
            _cliente = new Cliente()
            {
                Nome = "Fulano",
                Sobrenome = "de Tal",
                CPF = "64431078703",
                Email = "fulano@fulano.com.br",
                Ativo = true
            };

            Assert.IsFalse(_cliente.IsValid());
            Assert.Contains("Cliente informou um CPF Inválido", _cliente.ResultadoValidacao.Erros.Select(error => error.Message).ToList());
        }

        [Test]
        public void NaoDeveAceitarClienteSemEnderecoNaColecaoDeEnderecos()
        {
            _cliente = new Cliente()
            {
                Nome = "Fulano",
                Sobrenome = "de Tal",
                CPF = "73284946977",
                Email = "fulano@fulano.com.br",
                Ativo = true
            };

            Assert.IsFalse(_cliente.IsValid());
            Assert.Contains("Cliente não possui endereço castrado", _cliente.ResultadoValidacao.Erros.Select(error => error.Message).ToList());
        }
    }
}
