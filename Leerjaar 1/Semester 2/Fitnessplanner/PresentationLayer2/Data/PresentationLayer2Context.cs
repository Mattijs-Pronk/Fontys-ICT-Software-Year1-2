using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PresentationLayer2.Models;

namespace PresentationLayer2.Data
{
    public class PresentationLayer2Context : DbContext
    {
        public PresentationLayer2Context (DbContextOptions<PresentationLayer2Context> options)
            : base(options)
        {
        }

        public DbSet<PresentationLayer2.Models.MachineViewModel> MachineViewModel { get; set; }

        public DbSet<PresentationLayer2.Models.UserViewModel> UserViewModel { get; set; }

        public DbSet<PresentationLayer2.Models.TimeslotViewModel> TimeslotViewModel { get; set; }

        public DbSet<PresentationLayer2.Models.ReservationViewModel> ReservationViewModel { get; set; }

        public DbSet<PresentationLayer2.Models.MyreservationViewModel> MyreservationViewModel { get; set; }

        public DbSet<PresentationLayer2.Models.ProgramMachineViewModel> ProgramMachineViewModel { get; set; }
    }
}
