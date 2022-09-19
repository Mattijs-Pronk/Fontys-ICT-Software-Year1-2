using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer2.Models
{
    public class ListViewModel
    {
        public List<UserViewModel> allusers = new List<UserViewModel>();

        public List<MachineViewModel> allmachines = new List<MachineViewModel>();

        public List<TimeslotViewModel> alltimeslots = new List<TimeslotViewModel>();

        public List<ReservationViewModel> availabletimeslots = new List<ReservationViewModel>();

        public List<MyreservationViewModel> myreservations = new List<MyreservationViewModel>();

        public List<MyreservationViewModel> programs = new List<MyreservationViewModel>();

        public List<ProgramMachineViewModel> machines = new List<ProgramMachineViewModel>();

        public List<ProgramMachineViewModel> allprograms = new List<ProgramMachineViewModel>();
    }
}
