using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTest
  {
    // Test methods will go here.
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item() // NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue())
    {                                                        // CreatesInstanceOfItem is the description of the behavior we're attempting to confirm.
      Item newItem = new Item();                             // Item is the expected return value of the method we're testing, because an Item class will create Item objects.
      Assert.AreEqual(typeof(Item), newItem.GetType());      // typeof returns the data type of a class. 
    }                                                        // GetType() returns the data type of a specific object.           
                                                             // In the test above we're simply confirming that the newItem object we create is of the Item data type. Pretty simple, yeah?
                                                       
    [TestMethod]                                             
    public void GetDescription_ReturnsDescription_String()
    {
      // Arrange
      string description = "Walk the dog.";
      Item newItem = new Item(description);
      // Act
      string result = newItem.GetDescription(); //** getter method works because we are putting the value in result and mathching it with the va;ue we pass intp the constructor */
      //Assert
      Assert.AreEqual(description, result);
      // Create a new string called description.
      // Create a new Item object, passing in the description.
      // Record the result of calling a GetDescription() getter method on the newItem.
      // Confirm the description retrieved from the Item object matches the description string provided to the constructor.

      // Arrange: Gathering, declaring and/or creating all necessary components for the test. (Like when we create our description and newItems in the test above).
      // Act: Invoking the functionality we're testing; often by calling a method. (Like when we call newItem.GetDescription(); in the spec above testing the GetDescription() method.)
      // Assert: Confirm the functionality works as anticipated, by comparing its output with the anticipated output. (The line that begins with Assert in the test above.)
    }
  }
}



