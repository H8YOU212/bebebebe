namespace TestProject1
{
    public class Tests
    {
        bebebebe.Program program;
        [SetUp]
        public void Setup()
        {
            program = new bebebebe.Program();
        }

        [Test]
        public void F_5_3_Return_8()
        {
            Assert.That(program.F(5, 3), Is.EqualTo(8));
        }

        [Test]
        public void D_1_4_2_Return_8()
        {
            Assert.That(program.D(1,-4,2), Is.EqualTo(8));
        }

        [Test]
        public void D_4__1__5_Return_81()
        {
            Assert.That(program.D(4,-1,-5), Is.EqualTo(81));
        }
    }
}