﻿using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Swashbuckle.Dummy.Controllers
{
    public class JaggedArraysController : ApiController
    {
        public int Create(int[][] matrix)
        {
            throw new NotImplementedException();
        }

        public Token GetAll()
        {
            throw new NotImplementedException();
        }
    }

    public class Token : List<Token>
    {}
}