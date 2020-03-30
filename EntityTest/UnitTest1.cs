using Entity;
using HomeWork;
using NUnit.Framework;

namespace EntityTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsHeadTest()
        {
            DoubleLinkNode node1 = new DoubleLinkNode();
            DoubleLinkNode node2 = new DoubleLinkNode();
            DoubleLinkNode node3 = new DoubleLinkNode();
            DoubleLinkNode node4 = new DoubleLinkNode();
            DoubleLinkNode node5 = new DoubleLinkNode();

            node2.InsertAffter(node1);
            node3.InsertAffter(node2);
            node4.InsertAffter(node3);
            node5.InsertAffter(node4);



            Assert.IsNull(node1.Previous);
            Assert.IsTrue(node1.IsHead);
            Assert.AreEqual(node1.Next, node2);
            Assert.AreEqual(node2.Previous, node1);
            
            Assert.IsFalse(node1.IsTail);

            Assert.IsFalse(node2.IsHead);
            Assert.AreEqual(node2.Next, node3);
            Assert.AreEqual(node3.Previous, node2);
            Assert.IsFalse(node2.IsTail);

            Assert.IsFalse(node3.IsHead);
            Assert.AreEqual(node3.Next, node4);
            Assert.AreEqual(node4.Previous, node3);
            Assert.IsFalse(node3.IsTail);

            ///����Ĵ�����Ҫʹ��ǰ��⣬��������Ⱦ����

            //node5.InsertAffter(node1);
            //Assert.AreEqual(node1.Next, node5);
            //Assert.AreEqual(node5.Previous, node1);
            //Assert.AreEqual(node5.Next, node2);
            //Assert.AreEqual(node2.Previous, node5);

            //node5.InsertAffter(node4);
            //Assert.AreEqual(node4.Next, node5);
            //Assert.AreEqual(node5.Previous, node4);
            //Assert.AreEqual(node5.Next, null);

            //node5.InsertBefore(node3);
            //Assert.AreEqual(node5.Next, node3);
            //Assert.AreEqual(node3.Previous, node5);
            //Assert.AreEqual(node5.Previous, node2);
            //Assert.AreEqual(node2.Next, node5);

            //node5.InsertBefore(node1);
            //Assert.AreEqual(node5.Next, node1);
            //Assert.AreEqual(node1.Previous, node5);
            //Assert.AreEqual(node5.Previous, null);

            ///ɾ���м��һ���ڵ� 1 2 3 4
            node2.Delete(node2);
            node3.Delete(node3);
            node4.Delete(node4);
            node5.Delete(node5);
            node1.Delete(node1);
            System.Console.WriteLine();
            Assert.AreEqual(node1.Next, null);
            Assert.AreEqual(node1.Previous, null);

            //ɾ��ͷ
            //node1.Delete(node1);
            //Assert.AreEqual(node2.Previous,null);
            //Assert.AreEqual(node2.Next, node3);

            //ɾ��β
            //node4.Delete(node4);
            //Assert.AreEqual(node3.Previous, node2);
            //Assert.AreEqual(node3.Next, null);

            //�м佻��1 2 3 4 5   //��������������⣬�������Ǹ���Ҳʵ����һ��
            //node2.Swap(node2, node4);
            //Assert.AreEqual(node2.Next, node5);
            //Assert.AreEqual(node2.Previous, node3);
            //Assert.AreEqual(node4.Next, node3);
            //Assert.AreEqual(node4.Previous, node1);
            //Assert.AreEqual(node3.Next, node2);
            //Assert.AreEqual(node5.Previous, node2);
            //Assert.AreEqual(node3.Previous, node4);
            //Assert.AreEqual(node1.Next, node4);

            //Swap����
            //node2.Swap(node4);
            //Assert.AreEqual(node2.Next, node5);
            //Assert.AreEqual(node2.Previous, node3);
            //Assert.AreEqual(node4.Next, node3);
            //Assert.AreEqual(node4.Previous, node1);
            //Assert.AreEqual(node3.Next, node2);
            //Assert.AreEqual(node5.Previous, node2);
            //Assert.AreEqual(node3.Previous, node4);
            //Assert.AreEqual(node1.Next, node4);


        }


        [Test]
        public void Test1()
        {
            ///1.Ϊ֮ǰ��ҵ��ӵ�Ԫ���ԣ������������ڣ�
            ///1.�������ҵ����ֵ
            ///2.�ҵ�100���ڵ���������
            ///3.��������Ϸ
            ///4.���ֲ���
            ///5.ջ��ѹ�뵯��
            ///

            ///1.�������ҵ����ֵ
            Assert.AreEqual(5331, HistoryHomeWork.FindMax(23, 131, 532, 5331, 123, 521));

            ///2.�ҵ�100���ڵ���������
            //Assert.AreEqual(11, HistoryHomeWork.isPrime(100));
            //Assert.AreEqual(100, HistoryHomeWork.isPrime(100));
            //Assert.AreEqual(20, HistoryHomeWork.isPrime(100));
            //Assert.AreEqual(13, HistoryHomeWork.isPrime(100));
            //Assert.AreEqual(53, HistoryHomeWork.isPrime(100));


            ///3.��������Ϸ
            HistoryHomeWork.GuessMe();//�����ô����

            ///4.���ֲ���
            ///  ���˰���Ϊɶһֱ�Ǵ�ģ��������ԭ����ʱд���ǲ����±ꡣ��������
            int[] array = new int[] { 23, 43, 56, 66, 77, 88, 99 };
            Assert.AreEqual(1, HistoryHomeWork.binarySeek(array, 43));

            ///5.ջ��ѹ�뵯��
            ///
            MimicStack test = new MimicStack();
            test.pop();
            test.push(23);
            test.pop();
            test.push(232);
            test.push(23);
            test.push(23);
            test.push(213541233);
            test.push(23);
            test.push(23);
            test.push(23);
            test.push(23);
            test.push(23);
            test.push(23);
            test.push(23);
            test.push(23);
            test.push(23);
            test.push(23);
            test.pop();

        }


        [Test]
        public void Test2()
        {
            HistoryHomeWork.isPrime(100);
            HistoryHomeWork.isPrime(-100);
            HistoryHomeWork.isPrime(100000);
            HistoryHomeWork.isPrime(23);
        }

        [Test]
        public void test3()
        {
            HomeWork.DataTimeCount.GetWeek(2000);
            HomeWork.DataTimeCount.GetWeek(1959);
            HomeWork.DataTimeCount.GetWeek(2100);
            HomeWork.DataTimeCount.GetWeek(1);

        }
    }
}