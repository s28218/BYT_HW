using Tut2_s20123;

namespace TestProject2
{
    public class Tests
    {
        private readonly IShape sphere = new Sphere(5);

        [Test]
        public void TestSphereCalculateArea()
        {
            Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
        }

        [Test]
        public void TestSphereCalculateVolume()
        {
            Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
        }

        //todo : Complete the remaning tests here

        [Test]
        public void TestR_V()
        {
            double r = 7;
            IShape sphere = new Sphere(r);
            double area = 4 * Math.PI * r * r;
            double volume = (4.0 / 3.0) * Math.PI * r * r * r;
            Assert.That(sphere.CalculateArea(), Is.EqualTo(area).Within(0.001));
            Assert.That(sphere.CalculateVolume(), Is.EqualTo(volume).Within(0.001));
        }

        [Test]
        public void Test_WrongR_V()
        {
            IShape emptysphere = new Sphere(0);
            IShape voidsphere = new Sphere(-1);
            Assert.That(emptysphere.CalculateArea(), Is.EqualTo(0).Within(0.001));
            Assert.That(emptysphere.CalculateVolume(), Is.EqualTo(0).Within(0.001));
            Assert.That(voidsphere.CalculateArea(), Is.EqualTo(0).Within(0.001));
            Assert.That(voidsphere.CalculateVolume(), Is.EqualTo(0).Within(0.001));

        }

        private readonly IShape cube = new Cube(8);

        [Test]
        public void TestCubeCalculateArea()
        {
            Assert.That(cube.CalculateArea(), Is.EqualTo(384));
        }

        [Test]
        public void TestCubeCalculateVolume()
        {
            Assert.That(cube.CalculateVolume(), Is.EqualTo(512));
        }

        [Test]
        public void TestCubeR_V()
        {
            double a = 5;
            IShape cube = new Cube(a);
            Assert.That(cube.CalculateArea(), Is.EqualTo(6 * a * a));
            Assert.That(cube.CalculateVolume(), Is.EqualTo(a * a * a));
        }

        [Test]
        public void TestWrongCubeR_V()
        {
            IShape nocube = new Cube(0);
            IShape voidcube = new Cube(-1);
            Assert.That(nocube.CalculateArea(), Is.LessThan(0));
            Assert.That(nocube.CalculateVolume(), Is.LessThan(0));
            Assert.That(voidcube.CalculateArea(), Is.LessThan(0));
            Assert.That(voidcube.CalculateVolume(), Is.LessThan(0));

        }

        private readonly IShape cylinder = new Cylinder(5, 12);

        [Test]
        public void TestCylinderCalculateArea()
        {
            Assert.That(cylinder.CalculateArea(), Is.EqualTo(534).Within(1));
        }

        [Test]
        public void TestCylinderCalculateVolume()
        {
            Assert.That(cylinder.CalculateVolume(), Is.EqualTo(942).Within(1));
        }

        [Test]
        public void TestCylinderR_V()
        {
            double r = 5, h = 12;
            IShape c = new Cylinder(r, h);
            double area = 2 * Math.PI * r * (r + h);
            double volume = Math.PI * r * r * h;

            Assert.That(c.CalculateArea(), Is.EqualTo(area).Within(0.001));
            Assert.That(c.CalculateVolume(), Is.EqualTo(volume).Within(0.001));
        }

        [Test]
        public void TestCylinderWrong_R_V()
        {
            IShape nocylinder = new Cylinder(0, 0);
            double area = 0;
            Assert.That(nocylinder.CalculateArea(), Is.EqualTo(area).Within(0.001));
            Assert.That(nocylinder.CalculateVolume(), Is.EqualTo(0));

            IShape voidcylinder = new Cylinder(-31, -1);
            Assert.That(voidcylinder.CalculateArea(), Is.LessThan(0));
            Assert.That(voidcylinder.CalculateVolume(), Is.LessThan(0));
        }

        private readonly IShape rectangle = new Rectangle(2, 3);

        [Test]
        public void TestRectangleCalculateArea()
        {
            Assert.That(rectangle.CalculateArea(), Is.EqualTo(6));
        }

        [Test]
        public void TestRectangleCalculateVolume()
        {
            Assert.That(rectangle.CalculateVolume(), Is.EqualTo(0));
        }

        [Test]
        public void TestRectangleR_V()
        {
            double l = 2, w = 3;
            IShape rectangle =  new Rectangle(l, w);
            Assert.That(rectangle.CalculateArea(), Is.EqualTo(l * w));
            Assert.That(rectangle.CalculateVolume(), Is.EqualTo(0));
        }

        [Test]
        public void TestRectangleWrong_R_V()
        {
            IShape norectangle = new Rectangle(0,0);
            IShape voidrectangle = new Rectangle(-1,-1);
            Assert.That(norectangle.CalculateArea(), Is.EqualTo(0));
            Assert.That(norectangle.CalculateVolume(), Is.EqualTo(0));
            Assert.That(voidrectangle.CalculateArea(), Is.LessThan(0));
            Assert.That(voidrectangle.CalculateVolume(), Is.EqualTo(0));
        }

    }
}