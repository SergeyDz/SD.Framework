//-----------------------------------------------------------------------
// <copyright file="DataEntityBaseTest.cs" company="SD">
//     Copyright (c) 2015. All rights reserved.
// </copyright>
// <author>Sergey Dzyuban</author>
//-----------------------------------------------------------------------
namespace SD.Framework.Data.Test
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestFixture]
    public class DataEntityBaseTest
    {
        [Test]
        public void Identity_WriteAndRead_SameResult()
        {
            DataEntityBase entity = new DataEntityBase();
            entity.Id = 5;

            Assert.AreEqual(5, entity.Id);
        }

        [Test]
        public void Class_CreateWithConstructor_IdentityIsZero()
        {
            DataEntityBase entity = new DataEntityBase();

            Assert.AreEqual(0, entity.Id);
        }

        [Test]
        public void Class_CreateWithConstructor_CreatedSuccesful()
        {
            DataEntityBase entity = new DataEntityBase();

            Assert.IsNotNull(entity);
        }
    }
}
