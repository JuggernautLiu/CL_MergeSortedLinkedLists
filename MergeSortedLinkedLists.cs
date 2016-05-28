using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_MergeSortedLinkedLists
{
    public class MergeSortedLinkedLists
    {
        public Node Add(Node head1, Node newnode)
        {
            Node last = null;
            
            if (null == head1)
            {
                last = newnode;
            }
            else
            {
                Node tempA = head1;
                while (null != tempA.next)
                {                   
                    tempA = tempA.next;
                }
                tempA.next = newnode;
                last = head1;                
            }            
            return last;
        }        

        public Node Merge(Node head1, Node head2)
        {
            if (null == head1 && null == head2)
            {
                return null;
            }
            else if(null == head2)
            {
                return head1;
            }
            else if(null == head1)
            {
                return head2;
            }

            Node result = null;
            Node temp1 = head1;
            Node temp2 = head2;

            bool bHead1Finish = false;
            bool bHead2Finish = false;

            while (!bHead1Finish || !bHead2Finish)
            {
                if (bHead1Finish)
                {
                    result = Add(result, temp2);
                    break;
                }

                if (bHead2Finish)
                {
                    result = Add(result, temp1);
                    break;
                }

                if (temp1.data <= temp2.data)
                {
                    Node node = new Node();
                    node.data = temp1.data;
                    node.next = null;
                    result = Add(result, node);
                    temp1 = temp1.next;
                }
                else
                {
                    Node node = new Node();
                    node.data = temp2.data;
                    node.next = null;
                    result = Add(result, node);
                    temp2 = temp2.next;
                }

                if(null == temp1)
                    bHead1Finish = true;
                if(null == temp2)
                    bHead2Finish = true;
            }
            return result;
        }

        public string printData(Node head)
        {
            var output = String.Empty;
            if(null != head)
            {
                StringBuilder SB = new StringBuilder();
                Node temp = new Node();
                temp = head;
                while (null != temp)
                {
                    SB.Append(temp.data).Append(",");
                    temp = temp.next;
                }
                if (SB.Length > 0)
                    SB.Remove(SB.Length - 1, 1);

                output = SB.ToString();
            }
            return output;
        }
    }
}
