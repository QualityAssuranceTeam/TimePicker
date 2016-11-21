using NUnit.Framework;
using NUnit.Core;

namespace SeleniumTests
{
    public class TestSuite
    {
        [Suite] public static TestSuite Suite
        {
            get
            {
                TestSuite suite = new TestSuite("TestSuite");
                suite.Add(new SetValidDataTP2());
                suite.Add(new SetValidDataTP4());
                suite.Add(new CheckDefaultValueTP1());
                suite.Add(new DisplayFormatLablel());
                suite.Add(new CheckPreloadedTimeTP3());
                return suite;
            }
        }
    }
}
