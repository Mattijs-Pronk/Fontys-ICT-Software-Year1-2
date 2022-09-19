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
    public class MachineUT
    {
        [TestMethod]
        public void Test_ToDTO()
        {
            //Arrange
            Machine machine = new Machine();
            MachineDTO dto = new MachineDTO();

            machine.MachineId = 2;
            machine.Machinetype = "Bicep";
            machine.Machinename = "Bicep extension";
            machine.Machinedescription = "Machine to train bicep";

            int expectedMachineId = 2;
            string expectedMachinetype = "Bicep";
            string expectedMachinename = "Bicep extension";
            string expectedMachinedescription = "Machine to train bicep";

            //Act
            dto = machine.ToDTO();

            //Assert
            Assert.AreEqual(expectedMachineId, dto.MachineId);
            Assert.AreEqual(expectedMachinetype, dto.Machinetype);
            Assert.AreEqual(expectedMachinename, dto.Machinename);
            Assert.AreEqual(expectedMachinedescription, dto.Machinedescription);
        }

        [TestMethod]
        public void Test_EditOneMachineById()
        {
            //Arrange
            Machine machine = new Machine(new MachineDummyDAL());

            int MachineID = 5;

            bool expected = true;

            //Act
            Machine mach = new Machine(MachineID);
            bool actual = machine.EditOneMachineById(mach);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
