﻿using AutoMapper;
using Exps.Core.Models;
using Exps.Core.Views;

namespace Exps.Core
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ExpenseModel, ExpenseTypeView>();
        }
    }
}