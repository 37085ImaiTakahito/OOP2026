using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcBasicSample.Data;

namespace MvcBasicSample.Controllers;
public class ProductsController : Controller {
    private readonly AppDbContext _db; //DBへ問い合わせるためのフィールド

    //ASP.NET Core から必要なAppDbContext を受け取る
    public ProductsController(AppDbContext db) {
        _db = db;
    }

    //  /Product/Index　で商品一覧を取得する（非同期メソッド）
    public async Task<IActionResult> Index() {

        //Idの昇順で取得し結果をList<Product>にする
        var products = await _db.Products
            .Where(product => product.Price > 500)
            .OrderBy(product => product.Id)
            .ToListAsync();

        //商品一覧をViewへ渡す
        return View(products);
    }

}

