﻿//  SOLUTION  ： 农业气象物联网V3
//  PROJECT     ： AhnqIot.Web
//  FILENAME   ： UserRegisterIotModel.cs
//  AUTHOR     ： soft-cq
//  CREATE TIME： 14:59
//  COPYRIGHT  ： 版权所有 (C) 物联网科技有限公司 http://www.smartah.cc/ 2011~2016
namespace AhnqIot.Web.Areas.apiV1.Models
{
    public class UserRegisterIotModel : UserRegisterBaseModel
    {
        public string CompanyName { get; set; }

        public string Location { get; set; }
    }
}