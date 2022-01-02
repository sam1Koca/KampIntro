using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface IUserValidationService // Doğrulama Yapmak için temel İnterface
    {
        bool Validate(Gamer gamer);
    }
}
