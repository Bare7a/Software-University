﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsShop.Models
{
    public class User
    {
        private ICollection<User> friends;
        private ICollection<Product> productsSold;
        private ICollection<Product> productsBought;

        public User()
        {
            this.friends = new HashSet<User>();
            this.productsSold = new HashSet<Product>();
            this.productsBought = new HashSet<Product>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string LastName { get; set; }
        public int? Age { get; set; }

        public virtual ICollection<User> Friends
        {
            get { return this.friends; }
            set { this.friends = value; }
        }

        public virtual ICollection<Product> ProductsSold
        {
            get { return this.productsSold; }
            set { this.productsSold = value; }
        }

        public virtual ICollection<Product> ProductsBought
        {
            get { return this.productsBought; }
            set { this.productsBought = value; }
        }
    }
}
