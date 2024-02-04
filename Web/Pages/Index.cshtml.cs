using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Web.Data;
using Web.Data.Entities;

public class IndexModel : PageModel
{
    public List<BlogPost> BlogPosts { get; set; }

    public void OnGet()
    {
        // Fetch data from the backend in the future
        // For now, hard-code some sample data
        BlogPosts = StaticDatabase.BlogPosts;
        
    }


} 