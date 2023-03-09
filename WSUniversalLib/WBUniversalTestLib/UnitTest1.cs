using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WBUniversalTestLib
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetQuantityForProductHealth�heck()
        {
            //�������� �� �����������������
            WSUniversalLib.Calculation lib = new WSUniversalLib.Calculation();
            int value = lib.CalculationAmountMaterials(20,45,15,3,1);

            Assert.AreEqual(114147, value);
        }

        [TestMethod]
        public void GetQuantityForProductcheckingForBadData()
        {
            //�������� �� ������ ������ ������ 
            WSUniversalLib.Calculation lib = new WSUniversalLib.Calculation();
            int value = lib.CalculationAmountMaterials(1, -1, 2, 3, 1);
            Assert.AreEqual(-1, value);

        }

        [TestMethod]
        public void GetQuantityForProductcheckingForBadDataMatirial()
        {
            //�������� �� ������ ������ ��������� 

            WSUniversalLib.Calculation lib = new WSUniversalLib.Calculation();
            int value = lib.CalculationAmountMaterials(2, 9, 2, 0, 0);
        }
        [TestMethod]
        public void GetQuantityForProductcheckingForNonExistentData()
        {
            //�������� �� �������������� ������ ������
            
            WSUniversalLib.Calculation lib = new WSUniversalLib.Calculation();
            int value = lib.CalculationAmountMaterials(-1, 1, 1, 1, 1);
            Assert.AreEqual(-1, value);
        }

        [TestMethod]
        public void GetQuantityForProductcheckingForNonExistentDataMatirial()
        {
            //�������� �� �������������� ������ ����������

            WSUniversalLib.Calculation lib = new WSUniversalLib.Calculation();
            int value = lib.CalculationAmountMaterials(3, 9, 2, 4, 1);
        }
        [TestMethod]
        public void GetQuantityForProductcheckingForNonExistentDataProductOverwflow()
        {
            //�������� �� �������������� ������ ��������

            WSUniversalLib.Calculation lib = new WSUniversalLib.Calculation();
            int value = lib.CalculationAmountMaterials(1, 1, 1, 1, 4);
            Assert.AreEqual(-1, value);

        }
        [TestMethod]
        public void GetQuantityForProductcheckingForNonExistentDataMatirial2()
        {
            //�������� �� �������������� ������ ����������

            WSUniversalLib.Calculation lib = new WSUniversalLib.Calculation();
            int value = lib.CalculationAmountMaterials(3, 9, 2, -1, -1);
        }
        [TestMethod]
        public void GetQuantityForProductcheckingForNonExistentDataMatirial3()
        {
            //�������� �� �������������� ������ ����������

            WSUniversalLib.Calculation lib = new WSUniversalLib.Calculation();
            int value = lib.CalculationAmountMaterials(3, 9, 2, -1, -1);
        }
        [TestMethod]
        public void GetQuantityForProductcheckingForNonExistentDataMatirial4()
        {
            //�������� �� �������������� ������ ����������

            WSUniversalLib.Calculation lib = new WSUniversalLib.Calculation();
            int value = lib.CalculationAmountMaterials(4, 9, 2, -1, -1);
        }
        [TestMethod]
        public void GetQuantityForProductcheckingForNonExistentDataMatirial5()
        {
            //�������� �� �������������� ������ ����������

            WSUniversalLib.Calculation lib = new WSUniversalLib.Calculation();
            int value = lib.CalculationAmountMaterials(4, 9, 2, -1, -1);
        }
    }
}
