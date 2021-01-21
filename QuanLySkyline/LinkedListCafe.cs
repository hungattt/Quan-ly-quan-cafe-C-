using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySkyline
{
    class LinkedListCafe<L>
    {
        public LinkedListCafe()
        {
            pHead = null;
            pTail = null;
            count = 0;
        }

        public class Node
        {
            public L data;
            public Node pNext;
        }
        public Node pHead;
        public Node pTail;
        public int count;

        public Node CreNode(L info)
        {
            Node pNode = new Node();
            if (pNode != null)
            {
                pNode.data = info;
                pNode.pNext = null;
            }
            return pNode;
        }
        public void AddHead(L info)
        {
            Node NewNode = CreNode(info);

            if (NewNode == null)
            {
                return;
            }
            if (pHead == null)
            {
                pHead = pTail = NewNode;
            }
            else
            {
                NewNode.pNext = pHead;
                pHead = NewNode;
            }
            count++;
        }

        public void deletePhead()
        {
            if (pHead == null)
            {
                return;
            }
            Node p = pHead;
            pHead = pHead.pNext;
            p = null;
        }


        public void deleteAll()
        {
            while (pHead != null)
            {
                deletePhead();
            }
        }

        public void RemoveNode(Node pSearch)
        {
            Node pDelete = pHead;
            Node pPre = null;
            while (pDelete != null)
            {
                if (pDelete == pSearch)
                    break;
                pPre = pDelete;
                pDelete = pDelete.pNext;
            }
            if (pDelete == pHead)
            {
                pHead = pHead.pNext;
                pDelete.pNext = null;
                pDelete = null;
            }
            else if (pDelete.pNext == null)
            {
                pTail = pPre;
                pPre.pNext = null;
                pDelete = null;
            }
            else
            {
                pPre.pNext = pDelete.pNext;
                pDelete.pNext = null;
                pDelete = null;
            }
            count--;
        }

        
    }
}
