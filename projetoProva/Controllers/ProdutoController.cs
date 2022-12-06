using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projetoProva.Data;

namespace projetoProva.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly AppCont _appCont;

        public ProdutoController(AppCont appCont)
        {
            _appCont = appCont;
        }

        public IActionResult Index()
        {
            var allProdutos = _appCont.Produtos.ToList();
            return View(allProdutos);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var produto = await _appCont.Produtos.FirstOrDefaultAsync(m => m.ProdutoId == id);

            if (produto == null)
                return NotFound();

            return View(produto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produto = await _appCont.Produtos.FindAsync(id);
            _appCont.Produtos.Remove(produto);
            await _appCont.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
