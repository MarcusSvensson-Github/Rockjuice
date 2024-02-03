﻿using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class IndexModel : PageModel
{
    public List<BlogPost> BlogPosts { get; set; }

    public void OnGet()
    {
        // Fetch data from the backend in the future
        // For now, hard-code some sample data
        BlogPosts = new List<BlogPost>
        {
            new BlogPost { Title = "Climbing in San Vito Lo Capo, Sicily", Content = "San Vito, Sardinia, stands as an unspoiled paradise for climbing enthusiasts, boasting an extraordinary blend of rugged landscapes and pristine coastal beauty. Nestled along the emerald waters of the Mediterranean, the limestone cliffs of San Vito offer a diverse and challenging playground for climbers of all skill levels.\n\nThe unique geological formations provide an unparalleled variety of routes, from gentle crags for beginners to daunting overhangs for seasoned climbers. As the sun casts a warm glow on the rock faces, climbers are treated to breathtaking views of the azure sea and lush surroundings, creating a sensory-rich experience. San Vito's climbing community flourishes in the welcoming atmosphere, where local guides and fellow climbers share a passion for the sport.", VideoUrl = "https://www.youtube.com/embed/oKrPdaP3vTo?si=3VV_mCDBMRqwICOH" },
            // Add more posts as needed
        };
    }

    public class BlogPost
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string? VideoUrl { get; set; }

    }
}