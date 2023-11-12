
using MissingValues;

namespace Test.MissingNumber
{
     
    public class TestNice
    {

        [Fact]
        public void Return_Three_Missing_Number()
        {
            //Arrange
            var curList = new List<int>() { 1,5 };
            var expectedList = new List<int> { 2,3,4 };

            //Act
            var Founded = NiceApproach.FindMissing(curList);

            //Assert
            Assert.Equal(expectedList, Founded);

        }
        [Fact]
        public void Return_No_Missing_Number()
        {
            //Arrange
            var curList = new List<int>() { 1, 2};
            var expectedList = new List<int>();

            //Act
            var Founded = NiceApproach.FindMissing(curList);

            //Assert
            Assert.Equal(expectedList, Founded);

        }

        [Fact]
        public void Return_Argument_Null_Exception()
        {
            //Arrange
            var curList = new List<int>();

            // Act && Assert
            Assert.Throws<ArgumentNullException>(() => NiceApproach.FindMissing(curList));
    
        }

        [Fact]
        public void Return_Five_Missing_Number()
        {
            //Arrange
            var curList = new List<int>() { 7,3 };
            var expectedList = new List<int> { 4, 5, 6, 8, 9 };

            //Act
            var Founded = NiceApproach.FindMissing(curList);

            //Assert
            Assert.Equal(expectedList, Founded);

        }
    }
}
