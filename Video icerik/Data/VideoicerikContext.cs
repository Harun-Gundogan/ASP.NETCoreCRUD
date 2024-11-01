using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Video_icerik.Models;

namespace Video_icerik.Data
{
    public class VideoicerikContext : DbContext
    {
        public VideoicerikContext (DbContextOptions<VideoicerikContext> options)
            : base(options)
        {
        }

        public DbSet<Video_icerik.Models.Icerik> Icerik { get; set; } = default!;
    }
}
