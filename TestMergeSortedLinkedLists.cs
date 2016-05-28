using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CL_MergeSortedLinkedLists
{
    class TestMergeSortedLinkedLists
    {
        [Test]
        public void Add_from123_add4return1234()
        {
            Node nodes = new Node();
            nodes.data = 1;
            nodes.next = new Node();
            nodes.next.data = 2;
            nodes.next.next = new Node();
            nodes.next.next.data = 3;
            nodes.next.next.next = null;

            Node newnode = new Node();
            newnode.data = 4;
            newnode.next = null;

            var actual = String.Empty;
            var expected = "1,2,3,4";

            var sortProcessor = new MergeSortedLinkedLists();
            var actNode = sortProcessor.Add(nodes,newnode);
            actual = sortProcessor.printData(actNode);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Add_from1_add234return1234()
        {
            Node node1 = new Node();
            node1.data = 1;
            node1.next = null;

            Node newnodes = new Node();
            newnodes.data = 2;
            newnodes.next = new Node();
            newnodes.next.data = 3;
            newnodes.next.next = new Node();
            newnodes.next.next.data = 4;
            newnodes.next.next.next = null;

            

            var actual = String.Empty;
            var expected = "1,2,3,4";

            var sortProcessor = new MergeSortedLinkedLists();
            var actNode = sortProcessor.Add(node1, newnodes);
            actual = sortProcessor.printData(actNode);

            Assert.AreEqual(expected, actual);
        }
                
        [Test]
        public void printData_nullresult_returnEmpty()
        {
            // Arrange                   
            Node node1 = null;

            var sortProcessor = new MergeSortedLinkedLists();
            var actual = String.Empty;
            var expected = String.Empty;

            // Act
            actual = sortProcessor.printData(node1);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void printData()
        {
            // Arrange
            // head1 = 3,4,1            
            Node node1 = new Node();
            node1.data = 1;
            node1.next = null;

            Node node4 = new Node();
            node4.data = 4;
            node4.next = node1;

            Node node3 = new Node();
            node3.data = 3;
            node3.next = node4;           
            
            var sortProcessor = new MergeSortedLinkedLists();
            var actual = String.Empty;
            var expected = "3,4,1";

            // Act
            actual = sortProcessor.printData(node3);

            // Assert
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Merge_2NullArray_RetNull()
        {
            // Arrange
            // head1 = null
            // head2 = null
            Node head1 = null;
            Node head2 = null;

            var sortProcessor = new MergeSortedLinkedLists();
            Node actualNode = null;            

            // Act
            actualNode = sortProcessor.Merge(head1, head2);
            
            // Assert
            Assert.Null(actualNode);
        }

        [Test]
        public void Merge_head1Null_Rethead2()
        {
            // Arrange
            // head1 = null
            // head2 = null
            Node head1 = null;
            Node node3 = new Node();
            node3.data = 3;
            node3.next = null;

            Node node2 = new Node();
            node2.data = 2;
            node2.next = node3;

            Node node1 = new Node();
            node1.data = 1;
            node1.next = node2;

            Node head2 = node1;

            var sortProcessor = new MergeSortedLinkedLists();
            Node actualNode = sortProcessor.Merge(head1,head2);
            var actual = sortProcessor.printData(actualNode);
            var expected = "1,2,3";

            // Act
            actualNode = sortProcessor.Merge(head1, head2);

            // Assert
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Merge_head1_134_head2_25_return_12345()
        {
            // Arrange
            // head1 = 1,3,4
            // head2 = 2,5
            Node head1 = new Node();
            head1.data = 1;
            head1.next = new Node();
            head1.next.data = 3;
            head1.next.next = new Node();
            head1.next.next.data = 4;
            head1.next.next.next = null;

            Node head2 = new Node();
            head2.data = 2;
            head2.next = new Node();
            head2.next.data = 5;
            head2.next.next = null;

            var sortProcessor = new MergeSortedLinkedLists();
            var actualNode = new Node();
            var actual = String.Empty;
            var expected = "1,2,3,4,5";
            
            // Act
            actualNode = sortProcessor.Merge(head1, head2);
            actual = sortProcessor.printData(actualNode);
            // Assert
            Assert.AreEqual(expected, actual);            
        }

        [Test]
        public void Merge_head1_134_head2_2567_return_1234567()
        {
            // Arrange
            // head1 = 1,3,4
            // head2 = 2,5
            Node head1 = new Node();
            head1.data = 1;
            head1.next = new Node();
            head1.next.data = 3;
            head1.next.next = new Node();
            head1.next.next.data = 4;
            head1.next.next.next = null;

            Node head2 = new Node();
            head2.data = 2;
            head2.next = new Node();
            head2.next.data = 5;
            head2.next.next = new Node();
            head2.next.next.data = 6;
            head2.next.next.next = new Node();
            head2.next.next.next.data = 7;
            head2.next.next.next.next = null;

            var sortProcessor = new MergeSortedLinkedLists();
            var actualNode = new Node();
            var actual = String.Empty;
            var expected = "1,2,3,4,5,6,7";

            // Act
            actualNode = sortProcessor.Merge(head1, head2);
            actual = sortProcessor.printData(actualNode);
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
