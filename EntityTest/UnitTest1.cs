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

    }
}