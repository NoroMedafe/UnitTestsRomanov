using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WBUniversalTestLib
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetQuantityForProductHealthСheck()
        {
            //проверка на работоспособность
            WSUniversalLib.Calculation lib = new WSUniversalLib.Calculation();
            int value = lib.CalculationAmountMaterials(20,45,15,3,1);

            Assert.AreEqual(114147, value);
        }

        [TestMethod]
        public void GetQuantityForProductcheckingForBadData()
        {
            //проверка на плохие данные ширины 
            WSUniversalLib.Calculation lib = new WSUniversalLib.Calculation();
            int value = lib.CalculationAmountMaterials(1, -1, 2, 3, 1);
            Assert.AreEqual(-1, value);

        }

        [TestMethod]
        public void GetQuantityForProductcheckingForBadDataMatirial()
        {
            //проверка на плохие данные материала 

            WSUniversalLib.Calculation lib = new WSUniversalLib.Calculation();
            int value = lib.CalculationAmountMaterials(2, 9, 2, 0, 0);
        }
        [TestMethod]
        public void GetQuantityForProductcheckingForNonExistentData()
        {
            //проверка на несуществующие данные высоты
            
            WSUniversalLib.Calculation lib = new WSUniversalLib.Calculation();
            int value = lib.CalculationAmountMaterials(-1, 1, 1, 1, 1);
            Assert.AreEqual(-1, value);
        }

        [TestMethod]
        public void GetQuantityForProductcheckingForNonExistentDataMatirial()
        {
            //проверка на несуществующие данные материалов

            WSUniversalLib.Calculation lib = new WSUniversalLib.Calculation();
            int value = lib.CalculationAmountMaterials(3, 9, 2, 4, 1);
        }
        [TestMethod]
        public void GetQuantityForProductcheckingForNonExistentDataProductOverwflow()
        {
            //проверка на несуществующие данные продукта

            WSUniversalLib.Calculation lib = new WSUniversalLib.Calculation();
            int value = lib.CalculationAmountMaterials(1, 1, 1, 1, 4);
            Assert.AreEqual(-1, value);

        }
        [TestMethod]
        public void GetQuantityForProductcheckingForNonExistentDataMatirial2()
        {
            //проверка на несуществующие данные материалов

            WSUniversalLib.Calculation lib = new WSUniversalLib.Calculation();
            int value = lib.CalculationAmountMaterials(3, 9, 2, -1, -1);
        }
        [TestMethod]
        public void GetQuantityForProductcheckingForNonExistentDataMatirial3()
        {
            //проверка на несуществующие данные материалов

            WSUniversalLib.Calculation lib = new WSUniversalLib.Calculation();
            int value = lib.CalculationAmountMaterials(3, 9, 2, -1, -1);
        }
        [TestMethod]
        public void GetQuantityForProductcheckingForNonExistentDataMatirial4()
        {
            //проверка на несуществующие данные материалов

            WSUniversalLib.Calculation lib = new WSUniversalLib.Calculation();
            int value = lib.CalculationAmountMaterials(4, 9, 2, -1, -1);
        }
        [TestMethod]
        public void GetQuantityForProductcheckingForNonExistentDataMatirial5()
        {
            //проверка на несуществующие данные материалов

            WSUniversalLib.Calculation lib = new WSUniversalLib.Calculation();
            int value = lib.CalculationAmountMaterials(4, 9, 2, -1, -1);
        }
    }
}
