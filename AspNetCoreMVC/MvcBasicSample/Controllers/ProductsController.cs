using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcBasicSample.Data;

namespace MvcBasicSample.Controllers;
public class ProductsController : Controller {
    private readonly AppDbContext _db;

    public ProductsController(AppDbContext db) {
        _db = db;
    }
}

