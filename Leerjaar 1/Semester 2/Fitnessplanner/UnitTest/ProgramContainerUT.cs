using BusinessLogicLayer;
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
    public class ProgramContainerUT
    {
        [TestMethod]
        public void Test_AddOneProgram()
        {
            //Arrange
            ProgramContainer programContainer = new ProgramContainer(new ProgramDummyDAL());

            string expProgramName = "Tricep";
            string expProgramDescription = "Mooi programmatje";

            bool expected = true;

            //Act
            Program program = new Program(expProgramName, expProgramDescription);
            bool actual = programContainer.AddOneProgram(program);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_DeleteOneProgramById()
        {
            //Arrange
            ProgramContainer programContainer = new ProgramContainer(new ProgramDummyDAL());

            int expProgramId = 2;

            bool expected = true;

            //Act
            bool actual = programContainer.DeleteOneProgramById(expProgramId);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetAllPrograms()
        {
            //Arrange
            ProgramContainer programContainer = new ProgramContainer(new ProgramDummyDAL());
            List<Program> expected = new List<Program>();
            Program program = new Program();

            program.ProgramId = 2;
            program.ProgramName = "Tricep";
            program.ProgramDescription = "Train tricep yes";

            expected.Add(program);

            //Act
            List<Program> actual = programContainer.GetAllPrograms();

            //Assert
            Assert.AreEqual(expected.Count, actual.Count);
        }

        [TestMethod]
        public void Test_GetOneProgramById()
        {
            //Arrange
            ProgramContainer programContainer = new ProgramContainer(new ProgramDummyDAL());
            Program expected = new Program();

            expected.ProgramId = 2;
            expected.ProgramName = "Tricep";
            expected.ProgramDescription = "Train tricep yes";


            //Act
            Program actual = programContainer.GetOneProgramById(expected.ProgramId);


            //Assert
            Assert.AreEqual(expected.ProgramId, actual.ProgramId);
            Assert.AreEqual(expected.ProgramName, actual.ProgramName);
            Assert.AreEqual(expected.ProgramDescription, actual.ProgramDescription);
        }

        [TestMethod]
        public void Test_GetOneProgramByName()
        {
            //Arrange
            ProgramContainer programContainer = new ProgramContainer(new ProgramDummyDAL());
            Program expected = new Program();

            expected.ProgramId = 2;
            expected.ProgramName = "Tricep";
            expected.ProgramDescription = "Train tricep yes";


            //Act
            Program actual = programContainer.GetOneProgramByName(expected.ProgramName);


            //Assert
            Assert.AreEqual(expected.ProgramId, actual.ProgramId);
            Assert.AreEqual(expected.ProgramName, actual.ProgramName);
            Assert.AreEqual(expected.ProgramDescription, actual.ProgramDescription);
        }
    }
}
