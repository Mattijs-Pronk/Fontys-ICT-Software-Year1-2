using BusinessLogicLayer;
using InterfaceLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class MachineContainerUT
    {
        [TestMethod]
        public void Test_AddOneMachine()
        {
            //Arrange
            MachineContainer machineContainer = new MachineContainer(new MachineDummyDAL());

            string machinetype = "Tricep";
            string machinename = "Tricep extension";
            string machinedescription = "Machine to train tricep";

            bool expected = true;

            //Act
            Machine mach = new Machine(machinetype, machinename, machinedescription);
            bool actual = machineContainer.AddOneMachine(mach);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_DeleteOneMachineById()
        {
            //Arrange
            MachineContainer machineContainer = new MachineContainer(new MachineDummyDAL());

            int machineId = 2;

            bool expected = true;

            //Act
            bool actual = machineContainer.DeleteOneMachineById(machineId);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetOneMachineByMachineName()
        {
            //Arrange
            MachineContainer machineContainer = new MachineContainer(new MachineDummyDAL());

            int expmachineId = 2;
            string expmachinetype = "Tricep";
            string expmachinename = "Tricep extension";
            string expmachinedescription = "Machine to train tricep";

            //Act
            Machine actual = machineContainer.GetOneMachineByMachineName(expmachinename);

            //Assert
            Assert.AreEqual(expmachineId, actual.MachineId);
            Assert.AreEqual(expmachinetype, actual.Machinetype);
            Assert.AreEqual(expmachinename, actual.Machinename);
            Assert.AreEqual(expmachinedescription, actual.Machinedescription);
        }

        [TestMethod]
        public void Test_GetOneMachineById()
        {
            //Arrange
            MachineContainer machineContainer = new MachineContainer(new MachineDummyDAL());

            int expmachineId = 2;
            string expmachinetype = "Tricep";
            string expmachinename = "Tricep extension";
            string expmachinedescription = "Machine to train tricep";

            //Act
            Machine actual = machineContainer.GetOneMachineById(expmachineId);

            //Assert
            Assert.AreEqual(expmachineId, actual.MachineId);
            Assert.AreEqual(expmachinetype, actual.Machinetype);
            Assert.AreEqual(expmachinename, actual.Machinename);
            Assert.AreEqual(expmachinedescription, actual.Machinedescription);
        }

        [TestMethod]
        public void Test_GetAllMachinesByMachineType()
        {
            //Arrange
            MachineContainer machineContainer = new MachineContainer(new MachineDummyDAL());
            List<Machine> expected = new List<Machine>();
            Machine machine = new Machine();

            string machinetype = "Tricep";

            machine.MachineId = 1;
            machine.Machinetype = "Tricep";
            machine.Machinename = "Tricep extension";
            machine.Machinedescription = "Machine to train tricep";

            expected.Add(machine);

            //Act
            List<Machine> actual = machineContainer.GetAllMachinesByMachineType(machinetype);

            //Assert
            Assert.AreEqual(expected.Count, actual.Count);
        }

        [TestMethod]
        public void Test_GetAllMachines()
        {
            //Arrange
            MachineContainer machineContainer = new MachineContainer(new MachineDummyDAL());
            List<Machine> expected = new List<Machine>();
            Machine machine = new Machine();

            machine.MachineId = 1;
            machine.Machinetype = "Tricep";
            machine.Machinename = "Tricep extension";
            machine.Machinedescription = "Machine to train tricep";

            expected.Add(machine);

            //Act
            List<Machine> actual = machineContainer.GetAllMachines();

            //Assert
            Assert.AreEqual(expected.Count, actual.Count);
        }
    }
}
