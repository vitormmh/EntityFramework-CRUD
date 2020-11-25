using DemoCRUD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoCRUD.AcessoDados
{
    public class LivrosInit : CreateDatabaseIfNotExists<LivroContexto>
    {

        protected override void Seed(LivroContexto contexto)
        {
            List<Genero> generos = new List<Genero>()
            {
                new Genero() {Nome = "Teste1"},
                new Genero() {Nome = "Teste2"},
                new Genero() {Nome = "Teste3"},
                new Genero() {Nome = "Teste4"},
                new Genero() {Nome = "Teste5"},
                new Genero() {Nome = "Teste6"},
                new Genero() {Nome = "Teste7"},
                new Genero() {Nome = "Teste8"},
                new Genero() {Nome = "Teste9"},
                new Genero() {Nome = "Teste10"},
                new Genero() {Nome = "Teste11"},
                new Genero() {Nome = "Teste12"},
                new Genero() {Nome = "Teste13"},
                new Genero() {Nome = "Teste14"},
                new Genero() {Nome = "Teste15"},
                new Genero() {Nome = "Teste16"},
                new Genero() {Nome = "Teste17"},
                new Genero() {Nome = "Teste18"},
                new Genero() {Nome = "Teste19"},
                new Genero() {Nome = "Teste20"}
            };

            generos.ForEach(g => contexto.Generos.Add(g));

            List<Livro> livros = new List<Livro>()
            {
                new Livro()
                {
                    Titulo = "Apenas mais um ...",
                    Autor = "Vitor Henriques",
                    AnoEdicao = 2020,
                    Valor = 20,
                    Genero = generos.FirstOrDefault(g => g.Nome =="Teste1")
                },
                 new Livro()
                {
                    Titulo = "Apenas outro...",
                    Autor = "Vitor Henriques",
                    AnoEdicao = 2020,
                    Valor = 15,
                       Genero = generos.FirstOrDefault(g => g.Nome =="Teste2")
                },
                  new Livro()
                {
                    Titulo = "Apenas mais um ...",
                    Autor = "Vitor Henriques",
                    AnoEdicao = 2020,
                    Valor = 20,
                    Genero = generos.FirstOrDefault(g => g.Nome =="Teste3")
                },
                 new Livro()
                {
                    Titulo = "Apenas outro...",
                    Autor = "Vitor Henriques",
                    AnoEdicao = 2020,
                    Valor = 15,
                       Genero = generos.FirstOrDefault(g => g.Nome =="Teste4")
                },
                  new Livro()
                {
                    Titulo = "Apenas mais um ...",
                    Autor = "Vitor Henriques",
                    AnoEdicao = 2020,
                    Valor = 20,
                    Genero = generos.FirstOrDefault(g => g.Nome =="Teste5")
                },
                 new Livro()
                {
                    Titulo = "Apenas outro...",
                    Autor = "Vitor Henriques",
                    AnoEdicao = 2020,
                    Valor = 15,
                       Genero = generos.FirstOrDefault(g => g.Nome =="Teste6")
                },
                  new Livro()
                {
                    Titulo = "Apenas mais um ...",
                    Autor = "Vitor Henriques",
                    AnoEdicao = 2020,
                    Valor = 20,
                    Genero = generos.FirstOrDefault(g => g.Nome =="Teste7")
                },
                 new Livro()
                {
                    Titulo = "Apenas outro...",
                    Autor = "Vitor Henriques",
                    AnoEdicao = 2020,
                    Valor = 15,
                       Genero = generos.FirstOrDefault(g => g.Nome =="Teste8")
                },
                  new Livro()
                {
                    Titulo = "Apenas mais um ...",
                    Autor = "Vitor Henriques",
                    AnoEdicao = 2020,
                    Valor = 20,
                    Genero = generos.FirstOrDefault(g => g.Nome =="Teste9")
                },
                 new Livro()
                {
                    Titulo = "Apenas outro...",
                    Autor = "Vitor Henriques",
                    AnoEdicao = 2020,
                    Valor = 15,
                       Genero = generos.FirstOrDefault(g => g.Nome =="Teste10")
                },
                  new Livro()
                {
                    Titulo = "Apenas mais um ...",
                    Autor = "Vitor Henriques",
                    AnoEdicao = 2020,
                    Valor = 20,
                    Genero = generos.FirstOrDefault(g => g.Nome =="Teste11")
                },
                 new Livro()
                {
                    Titulo = "Apenas outro...",
                    Autor = "Vitor Henriques",
                    AnoEdicao = 2020,
                    Valor = 15,
                       Genero = generos.FirstOrDefault(g => g.Nome =="Teste12")
                },
                  new Livro()
                {
                    Titulo = "Apenas mais um ...",
                    Autor = "Vitor Henriques",
                    AnoEdicao = 2020,
                    Valor = 20,
                    Genero = generos.FirstOrDefault(g => g.Nome =="Teste13")
                },
                 new Livro()
                {
                    Titulo = "Apenas outro...",
                    Autor = "Vitor Henriques",
                    AnoEdicao = 2020,
                    Valor = 15,
                       Genero = generos.FirstOrDefault(g => g.Nome =="Teste14")
                },
                  new Livro()
                {
                    Titulo = "Apenas mais um ...",
                    Autor = "Vitor Henriques",
                    AnoEdicao = 2020,
                    Valor = 20,
                    Genero = generos.FirstOrDefault(g => g.Nome =="Teste15")
                },
                 new Livro()
                {
                    Titulo = "Apenas outro...",
                    Autor = "Vitor Henriques",
                    AnoEdicao = 2020,
                    Valor = 15,
                       Genero = generos.FirstOrDefault(g => g.Nome =="Teste16")
                },
                  new Livro()
                {
                    Titulo = "Apenas mais um ...",
                    Autor = "Vitor Henriques",
                    AnoEdicao = 2020,
                    Valor = 20,
                    Genero = generos.FirstOrDefault(g => g.Nome =="Teste17")
                },
                 new Livro()
                {
                    Titulo = "Apenas outro...",
                    Autor = "Vitor Henriques",
                    AnoEdicao = 2020,
                    Valor = 15,
                       Genero = generos.FirstOrDefault(g => g.Nome =="Teste18")
                },
                  new Livro()
                {
                    Titulo = "Apenas mais um ...",
                    Autor = "Vitor Henriques",
                    AnoEdicao = 2020,
                    Valor = 20,
                    Genero = generos.FirstOrDefault(g => g.Nome =="Teste19")
                },
                 new Livro()
                {
                    Titulo = "Apenas outro...",
                    Autor = "Vitor Henriques",
                    AnoEdicao = 2020,
                    Valor = 15,
                       Genero = generos.FirstOrDefault(g => g.Nome =="Teste20")
                }

            };

            livros.ForEach(w => contexto.Livros.Add(w));
            contexto.SaveChanges();
        }
    }
}