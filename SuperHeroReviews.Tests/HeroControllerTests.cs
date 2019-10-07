﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using SuperHeroReviews.Models;
using SuperHeroReviews.Models.HeroModel;
using Xunit;

namespace SuperHeroReviews.Tests
{
    public class HeroControllerTests
    {
        HeroModel herotest;
        public HeroControllerTests()
        {
            herotest = new HeroModel(21, "Hero Name", "review", "Universe", "Content", "Img");

        }
            



        [Fact]
        public void CourseConstructor_Sets_Name_On_Course_Model()
        {
            var result = herotest.Name;

            Assert.Equal("Hero Name", result);
        }

        [Fact]
        public void CourseConstructor_Sets_ID()
        {
            var result = herotest.ID;

            Assert.Equal(21, result);

        }

        [Fact]
        public void CourseConstructor_Sets_Review()
        {
            var result = herotest.Review;

            Assert.Equal("review", result);
        }

        [Fact]
        public void CourseConstructor_Sets_Universe()
        {
            var result = herotest.Universe;

            Assert.Equal("Universe", result);

        }

        [Fact]
        public void CourseConstructor_Sets_Content()
        {
            var result = herotest.Content;

            Assert.Equal("Content", result);
        }

        [Fact]
        public void CourseConstructor_Sets_Image()
        {
            var result = herotest.Image;

            Assert.Equal("Img", result);
        }


    }
}
