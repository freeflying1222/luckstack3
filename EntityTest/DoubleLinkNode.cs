using Entity;
using HomeWork;
using NUnit.Framework;

namespace EntityTest
{
    public class DoubleLinkNodeText
    {
        DoubleLinkNode node1, node2, node3, node4, node5,node6;
        [SetUp]
        public void Setup()
        {
            node1 = new DoubleLinkNode();
            node2 = new DoubleLinkNode();
            node3 = new DoubleLinkNode();
            node4 = new DoubleLinkNode();
            node5 = new DoubleLinkNode();
            node6 = new DoubleLinkNode();


            node2.InsertAfter(node1);
            node3.InsertAfter(node2);
            node4.InsertAfter(node3);
            node5.InsertAfter(node4);
        }

        /// <summary>
        /// SetUp����
        /// </summary>
        [Test]
        public void SetUpTest()
        {
            Assert.IsNull(node1.Previous);

            Assert.AreEqual(node1.Next, node2); 
            Assert.AreEqual(node2.Previous, node1);
            Assert.AreEqual(node2.Next, node3); 
            Assert.AreEqual(node3.Previous, node2);
            Assert.AreEqual(node3.Next, node4); 
            Assert.AreEqual(node4.Previous, node3);
            Assert.AreEqual(node4.Next, node5);
            Assert.AreEqual(node5.Previous, node4);

            Assert.IsNull(node5.Next);

        }




        /// <summary>
        /// û��ʵ��Max��TDD
        /// </summary>
        [Test]
        public void MaxTest()
        {
        //    Assert.IsTrue(node1.Max());
        //    Assert.IsFalse(node2.Max());
        //    Assert.IsFalse(node3.Max());
        //    Assert.IsFalse(node4.Max());
        //    Assert.IsTrue(node5.Max());

        }





        /// <summary>
        /// ͷ��β�Ĳ���
        /// </summary>
        [Test]
        public void IsHeadAndTailTest()
        {
            Assert.IsNull(node1.Previous);
            Assert.IsTrue(node1.IsHead);

            Assert.IsNull(node5.Next);
            Assert.IsTrue(node5.IsTail);
        }





        /// <summary>
        /// InsertAffter���м����
        /// </summary>
        [Test]
        public void InsertAfterTest()
        {
            //����ǰ 1 2 3 4 5 
            node6.InsertAfter(node1);
            //����� 1 [6] 5 2 3 4 
            Assert.AreEqual(node1.Next, node6);
            Assert.AreEqual(node6.Previous, node1);

            Assert.AreEqual(node6.Next, node2);
            Assert.AreEqual(node2.Previous, node6);
        }

        /// <summary>
        /// InsertAffter��ͷ���м����
        /// </summary>
        [Test]
        public void InsertAfter_HeadAfterMiddle()
        {
            //����ǰ 1 2 3 4 5 
            node1.InsertAfter(node3);
            //����� 2 3 [1] 4 5 

            Assert.IsNull(node2.Previous);

            Assert.AreEqual(node3.Next, node1);
            Assert.AreEqual(node1.Previous, node3);

            Assert.AreEqual(node1.Next, node4);
            Assert.AreEqual(node4.Previous, node1);
        }

        /// <summary>
        /// InsertAffter��ͷ����β
        /// </summary>
        [Test]
        public void InsertAfter_HeadAfterTail()
        {
            //����ǰ 1 2 3 4 5 
            node1.InsertAfter(node5);
            //����� 2 3 4 5 [1] 

            Assert.IsNull(node2.Previous);

            Assert.AreEqual(node5.Next, node1);
            Assert.AreEqual(node1.Previous, node5);

            Assert.IsNull(node1.Next);
        }

        /// <summary>
        /// InsertAffter��β�������м����
        /// </summary>
        [Test]
        public void InsertAfter_TailAfterMiddle()
        {
            //����ǰ 1 2 3 4 5
            node5.InsertAfter(node1);
            //����� 1 [5] 2 3 4 

            Assert.AreEqual(node5.Previous, node1);
            Assert.AreEqual(node1.Next, node5);

            Assert.AreEqual(node5.Next, node2);
            Assert.AreEqual(node2.Previous, node5);

            Assert.IsNull(node4.Next);
        }

        /// <summary>
        /// InsertAffter���м�������
        /// </summary>
        [Test]
        public void InsertAfter_MiddleAfterMiddle()
        {
            //����ǰ 1 2 3 4 5
            node2.InsertAfter(node4);
            //����� 1 3 4 [2] 5

            Assert.AreEqual(node2.Previous, node4);
            Assert.AreEqual(node2.Next, node5);

            Assert.AreEqual(node4.Next, node2);
            Assert.AreEqual(node5.Previous, node2);
        }

        /// <summary>
        /// InsertAffter�����ڲ���
        /// </summary>
        [Test]
        public void InsertAfter_Neighbor()
        {
            //����ǰ 1 2 3 4 5
            node2.InsertAfter(node3);
            //����� 1 [3] [2] 4 5 

            Assert.AreEqual(node1.Next, node3);
            Assert.AreEqual(node3.Previous, node1);

            Assert.AreEqual(node3.Next, node2);
            Assert.AreEqual(node2.Previous, node3);

            Assert.AreEqual(node2.Next, node4);
        }




        /// <summary>
        /// InsertBeforeβ���м����
        /// </summary>
        [Test]
        public void InsertBeforeTest()
        {
            //InsertBefore������InsertAfter������ֻ����һ��
            //����ǰ1 2 3 4 5
            node5.InsertBefore(node3);
            //�����1 2 [5] 3 4

            Assert.AreEqual(node5.Next, node3);
            Assert.AreEqual(node3.Previous, node5);
            Assert.AreEqual(node5.Previous, node2);
            Assert.AreEqual(node2.Next, node5);
        }




        /// <summary>
        /// ɾ��ͷ���
        /// </summary>
        [Test]
        public void Delete_HeadTest()
        {
            //ɾ��ǰ1 2 3 4 5 
            node1.Delete();
            //ɾ���� 2 3 4 5

            Assert.IsNull(node1.Next);
            Assert.IsNull(node2.Previous);

            //ɾ��ǰ 2 3 4 5
            node2.Delete();
            //ɾ���� 3 4 5

            Assert.IsNull(node2.Next);
            Assert.IsNull(node3.Previous);

            //ɾ��ǰ 3 4 5
            node3.Delete();
            //ɾ���� 4 5
            Assert.IsNull(node3.Next);
            Assert.IsNull(node4.Previous);

            //ɾ��ǰ 4 5
            node4.Delete();
            //ɾ���� 5

            Assert.IsNull(node4.Next);
            Assert.IsNull(node5.Previous);


            //���һ���޷���ɾ��
            node5.Delete();

            Assert.IsNull(node5.Previous);
            Assert.IsNull(node5.Next);

        }

        /// <summary>
        /// ɾ��β���
        /// </summary>
        [Test]
        public void Delete_TailTest()
        {
            //ɾ��ǰ 1 2 3 4 5 
            node5.Delete();
            //ɾ���� 1 2 3 4 

            Assert.IsNull(node5.Previous);
            Assert.IsNull(node4.Next);

            //ɾ��ǰ1 2 3 4 
            node4.Delete();
            //ɾ����1 2 3 

            Assert.IsNull(node4.Previous);
            Assert.IsNull(node3.Next);

            //ɾ��ǰ1 2 3
            node3.Delete();
            //ɾ����1 2
            Assert.IsNull(node3.Previous);
            Assert.IsNull(node2.Next);

            //ɾ��ǰ 1 2
            node2.Delete();
            //ɾ���� 1

            Assert.IsNull(node2.Previous);
            Assert.IsNull(node1.Next);

            //���һ�����ܱ�ɾ�� 1
            node1.Delete();

            Assert.IsNull(node1.Previous);
            Assert.IsNull(node1.Next);
        }

        /// <summary>
        /// ɾ��ͷ�м���
        /// </summary>
        [Test]
        public void DeleteTest()
        {
            //ɾ��ǰ1 2 3 4 5
            node2.Delete();
            //ɾ����1 3 4 5

            Assert.AreEqual(node1.Next, node3);
            Assert.AreEqual(node3.Previous, node1);

            Assert.IsNull(node2.Previous);
            Assert.IsNull(node2.Next);

        }






        /// <summary>
        /// SwapTest�м佻��
        /// </summary>
        [Test]
        public void SwapTest()
        {
            //����ǰ������ 1 2 3 4 5 
            node2.Swap(node4);
            //����������� 1 [4] 3 [2] 5 

            Assert.AreEqual(node1.Next, node4);
            Assert.AreEqual(node4.Previous, node1);

            Assert.AreEqual(node4.Next, node3);
            Assert.AreEqual(node3.Previous, node4);

            Assert.AreEqual(node3.Next, node2);
            Assert.AreEqual(node2.Previous, node3);

            Assert.AreEqual(node2.Next, node5);
            Assert.AreEqual(node5.Previous, node2);
        }

        /// <summary>
        /// SwapTest���ڽ���
        /// </summary>
        [Test]
        public void SwapNeighborTest()
        {
            //����ǰ������ 1 2 3 4 5 
            node2.Swap(node3);
            //����������� 1 [3] [2] 4 5 

            Assert.AreEqual(node1.Next, node3);
            Assert.AreEqual(node3.Previous, node1);

            Assert.AreEqual(node3.Next, node2);
            Assert.AreEqual(node3.Previous, node1);

            Assert.AreEqual(node2.Next, node4);
            Assert.AreEqual(node2.Previous, node3);
            
            Assert.AreEqual(node4.Previous, node2);
        }

        /// <summary>
        /// SwapTestͷβ����
        /// </summary>
        [Test]
        public void Swap_HeadAndTail_Test()
        {
            //��ǰ���� 1 2 3 4 5 
            node1.Swap(node5);
            //��ǰ����������� [5] 2 3 4 [1] 

            Assert.IsNull(node1.Next);
            Assert.IsNull(node5.Previous);

            Assert.AreEqual(node2.Previous, node5);
            Assert.AreEqual(node5.Next, node2);

            Assert.AreEqual(node1.Previous, node4);
            Assert.AreEqual(node4.Next, node1);
        }

        /// <summary>
        /// SwapTestͷ�н���
        /// </summary>
        [Test]
        public void Swap_HeadAndMiddle_Test()
        {
            //��ǰ���� 1 2 3 4 5 
            node1.Swap(node3);
            //���������� [3] 2 [1] 4 5

            Assert.IsNull(node3.Previous);
            Assert.IsNotNull(node5.Previous);

            Assert.AreEqual(node3.Next, node2);
            Assert.AreEqual(node2.Previous, node3);

            Assert.AreEqual(node2.Next, node1);
            Assert.AreEqual(node1.Previous, node2);

            Assert.AreEqual(node1.Next, node4);
            Assert.AreEqual(node4.Previous, node1);
        }

        /// <summary>
        /// SwapTest���ڽ���
        /// </summary>
        [Test]
        public void Swap_Neighbor_Test()
        {
            //��ǰ���� 1 2 3 4 5 
            node2.Swap(node3);
            //���������� 1 [3] [2] 4 5

            Assert.AreEqual(node1.Next, node3);
            Assert.AreEqual(node3.Previous, node1);

            Assert.AreEqual(node3.Next, node2);
            Assert.AreEqual(node2.Previous, node3);

            Assert.AreEqual(node2.Next, node4);
            Assert.AreEqual(node4.Previous, node2);
        }

    }
}