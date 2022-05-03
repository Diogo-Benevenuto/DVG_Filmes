using NUnit.Framework;
using DVG_FilmesWeb.Model;
using System;

namespace DVG_FilmesWeb.Teste
{
    public class TesteCategoria
    {

        VIDEO_LOCADORAContext db;

        [SetUp]
        public void Setup()
        {
            db = new VIDEO_LOCADORAContext();
        }

        [Test]
        public void Incluir()
        {

                Tbcategorias ocat = new Tbcategorias();
                ocat.Descricao = "Inclusão";
                db.Tbcategorias.Add(ocat);
                db.SaveChanges();
                Assert.Pass();
          
            
        }

        [Test]
        public void Alterar()
        {
            Tbcategorias? ocat = db.Tbcategorias.Find(1);
            if(ocat!= null)
            {
                ocat.Descricao = "Inclusão";
                db.Entry(ocat).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                Assert.Pass();
            }
            else
            {
                Assert.Fail("Não Encontrou uma categoria para alterar");
            }
           
        }
    }
}