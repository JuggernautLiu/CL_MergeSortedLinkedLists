using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_MergeSortedLinkedLists
{
    public class MergeSortedLinkedLists
    {
        private Node pollFirst(ref Node basenode)
        {
            Node node = new Node();
            node.data = basenode.data;
            node.next = null;
            basenode = basenode.next;
            return node;
        }

        private void append(ref Node basenode, Node newnode)
        {   
            if (null == basenode)
            {
                basenode = newnode;
            }
            else
            {
                Node lastnode = basenode;
                while (null != lastnode.next)
                {
                    lastnode = lastnode.next;
                }
                lastnode.next = newnode;               
            }            
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
                    append(ref result, temp2);
                    break;
                }

                if (bHead2Finish)
                {   
                    append(ref result, temp1);
                    break;
                }
                
                if (temp1.data <= temp2.data)
                {   
                    Node node = pollFirst(ref temp1);
                    append(ref result, node);
                }
                else
                {  
                    Node node = pollFirst(ref temp2);
                    append(ref result, node);
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

        public Node appendForTest(Node basenode, Node newnode)
        {
            Node last = null;

            if (null == basenode)
            {
                last = newnode;
            }
            else
            {
                Node tempA = basenode;
                while (null != tempA.next)
                {
                    tempA = tempA.next;
                }
                tempA.next = newnode;
                last = basenode;
            }
            return last;
        }

    }
}
