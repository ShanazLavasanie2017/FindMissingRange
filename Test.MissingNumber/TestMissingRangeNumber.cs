using MissingValues;


namespace Test.MissingNumber
{
   public class TestMissingRangeNumber
    {
        [Fact]
        public void Find_Three_Missing_Range_Number()
        {
            //Arrange
            var curList = new List<int>() { 1, 5 };
            var expectedList = new List<int> { 2, 3, 4 };

            //Act
            var Founded = FindMissingNumber.FindMissingRangedNumber(curList);

            //Assert
            Assert.Equal(expectedList, Founded);

        }

        [Fact]
        public void Find_Five_Missing_Range_number()
        {
            //Arrange
            var curList = new List<int>() { 7, 3 };
            var expectedList = new List<int> { 4, 5, 6, 8, 9 };

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

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => FindMissingNumber.FindMissingRangedNumber(curList));


        }

        [Fact]
        public void No_Missing_Number()
        {
            //Arrange
            var curList = new List<int>() { 1, 2};
            var expectedList = new List<int>();

            //Act
            var Founded = FindMissingNumber.FindMissingRangedNumber(curList);

            //Assert
            Assert.Equal(expectedList, Founded);

        }
    }
}
