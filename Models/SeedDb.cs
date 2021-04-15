using Cars_Api.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cars_Api.Models
{
    public class SeedDb : DropCreateDatabaseIfModelChanges<Db>
    {
        protected override void Seed(Db context)
        {
            GetCarros().ForEach(c => context.carros.Add(c));
            GetMarcas().ForEach(p => context.marcas.Add(p));
        }

        private static List<Marca> GetMarcas()
        {
            var marcas = new List<Marca> {
                new Marca
                {
                    Codigo = 1,
                    Nome = "Fiat"
                },
                new Marca
                {
                    Codigo = 2,
                    Nome = "Chevrolet"
                },
                new Marca
                {
                    Codigo = 3,
                    Nome = "Volkswagen"
                },
                new Marca
                {
                    Codigo = 4,
                    Nome = "Ford"
                },
                new Marca
                {
                    Codigo = 5,
                    Nome = "Nissan"
                },
            };

            return marcas;
        }

        private static List<Carro> GetCarros()
        {
            var carros = new List<Carro> {
                new Carro
                {
                    MarcaCodigo = 1,
                    CarCodigo = 1,
                    Modelo = "Siena",
                    Ano = 2003,
                    Cor = "Prata"
               },
                new Carro
                {
                    MarcaCodigo = 2,
                    CarCodigo = 2,
                    Modelo = "Corsa",
                    Ano = 2003,
                    Cor = "Preto"
               },
                new Carro
                {
                    MarcaCodigo = 3,
                    CarCodigo = 3,
                    Modelo = "Polo",
                    Ano = 2018,
                    Cor = "Branco"
                },
                new Carro
                {
                    MarcaCodigo = 4,
                    CarCodigo = 4,
                    Modelo = "Fiesta",
                    Ano = 2018,
                    Cor = "Prata"
                },
                new Carro
                {
                   MarcaCodigo = 5,
                    CarCodigo = 5,
                    Modelo = "Hb20",
                    Ano = 2020,
                    Cor = "Preto"
                }
    };
            return carros;

        }
    }
}