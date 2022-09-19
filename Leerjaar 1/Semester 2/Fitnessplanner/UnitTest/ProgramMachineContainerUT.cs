using BusinessLogicLayer;
using InterfaceLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.DummyDAL;

namespace UnitTest
{
    [TestClass]
    public class ProgramMachineContainerUT
    {
        [TestMethod]
        public void Test_AddMachineToProgramById()
        {
            //Arrange
            ProgramMachineContainer programmachineContainer = new ProgramMachineContainer(new ProgramMachineDummyDAL());

            int expProgramID = 2;
            int expMachineID = 3;

            bool expected = true;


            //Act
            ProgramMachine prmachine = new ProgramMachine(expProgramID, expMachineID);
            bool actual = programmachineContainer.AddMachineToProgramById(prmachine);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_DeleteOneProgramMachineByProgramId()
        {
            //Arrange
            ProgramMachineContainer programmachineContainer = new ProgramMachineContainer(new ProgramMachineDummyDAL());

            int expProgramID = 2;

            bool expected = true;


            //Act
            bool actual = programmachineContainer.DeleteOneProgramMachineByProgramId(expProgramID);

            
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_DeleteOneProgramMachineByProgramMachineId()
        {
            //Arrange
            ProgramMachineContainer programmachineContainer = new ProgramMachineContainer(new ProgramMachineDummyDAL());

            int expProgramMachineID = 2;

            bool expected = true;


            //Act
            bool actual = programmachineContainer.DeleteOneProgramMachineByProgramMachineId(expProgramMachineID);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetOneProgramMachines()
        {
            //Arrange
            ProgramMachineContainer programmachineContainer = new ProgramMachineContainer(new ProgramMachineDummyDAL());
            ProgramMachine expected = new ProgramMachine();

            expected.ProgramMachineID = 5;
            expected.ProgramID = 2;
            expected.MachineID = 3;


            //Act
            ProgramMachine prmachine = new ProgramMachine(expected.ProgramID, expected.MachineID);
            ProgramMachine actual = programmachineContainer.GetOneProgramMachines(prmachine);

            //Assert
            Assert.AreEqual(expected.ProgramMachineID, actual.ProgramMachineID);
            Assert.AreEqual(expected.ProgramID, actual.ProgramID);
            Assert.AreEqual(expected.MachineID, actual.MachineID);
        }

        [TestMethod]
        public void Test_GetAllProgramMachinesById()
        {
            //Arrange
            ProgramMachineContainer programmachineContainer = new ProgramMachineContainer(new ProgramMachineDummyDAL());
            List<ProgramMachine> expected = new List<ProgramMachine>();
            ProgramMachine programmachine = new ProgramMachine();

            int ProgramID = 5;
            programmachine.ProgramMachineID = 2;
            programmachine.MachineID = 3;


            expected.Add(programmachine);


            //Act
            List<ProgramMachine> actual = programmachineContainer.GetAllProgramMachinesById(ProgramID);


            //Assert
            Assert.AreEqual(expected.Count, actual.Count);
        }
    }
}
