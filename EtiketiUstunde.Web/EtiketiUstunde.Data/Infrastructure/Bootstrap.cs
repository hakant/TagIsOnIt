using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using EtiketiUstunde.Data.Model;

namespace EtiketiUstunde.Data.Infrastructure
{
    public static class Bootstrap
    {
        #region Divisions

        private static readonly IEnumerable<Division> Divisons = new List<Division>
            {
                new Division
                    {
                        Id = 1,
                        Name = "BAYAN",
                        PriorityScore = 100,
                        Categories = new List<Category>
                            {
                                new Category
                                    {
                                        Id = 1,
                                        Name = "Mont",
                                        CategoryGroup = new CategoryGroup
                                            {
                                                Id = 1,
                                                Name = "1",
                                                PriorityScore = 100
                                            },
                                         DivisionId = 1,
                                         CategoryGroupId = 1,
                                         PriorityScore = 100
                                    },
                                    new Category
                                    {
                                        Id = 2,
                                        Name = "Ceket",
                                        CategoryGroup = new CategoryGroup
                                            {
                                                Id = 1,
                                                Name = "1",
                                                PriorityScore = 100
                                            },
                                         DivisionId = 1,
                                         CategoryGroupId = 1,
                                         PriorityScore = 90
                                    },
                                    new Category
                                    {
                                        Id = 3,
                                        Name = "Gunluk & Abiye Elbise",
                                        CategoryGroup = new CategoryGroup
                                            {
                                                Id = 1,
                                                Name = "1",
                                                PriorityScore = 100
                                            },
                                         DivisionId = 1,
                                         CategoryGroupId = 1,
                                         PriorityScore = 70
                                    },
                                    new Category
                                    {
                                        Id = 4,
                                        Name = "Etek",
                                        CategoryGroup = new CategoryGroup
                                            {
                                                Id = 1,
                                                Name = "1",
                                                PriorityScore = 100
                                            },
                                         DivisionId = 1,
                                         CategoryGroupId = 1,
                                         PriorityScore = 60
                                    },
                                    new Category
                                    {
                                        Id = 5,
                                        Name = "Şort",
                                        CategoryGroup = new CategoryGroup
                                            {
                                                Id = 1,
                                                Name = "1",
                                                PriorityScore = 100
                                            },
                                         DivisionId = 1,
                                         CategoryGroupId = 1,
                                         PriorityScore = 50
                                    },
                                    new Category
                                    {
                                        Id = 6,
                                        Name = "Tayt",
                                        CategoryGroup = new CategoryGroup
                                            {
                                                Id = 1,
                                                Name = "1",
                                                PriorityScore = 100
                                            },
                                         DivisionId = 1,
                                         CategoryGroupId = 1,
                                         PriorityScore = 40
                                    },
                                    new Category
                                    {
                                        Id = 7,
                                        Name = "Pantolon",
                                        CategoryGroup = new CategoryGroup
                                            {
                                                Id = 2,
                                                Name = "2",
                                                PriorityScore = 90
                                            },
                                         DivisionId = 1,
                                         CategoryGroupId = 2,
                                         PriorityScore = 100
                                    },
                                    new Category
                                    {
                                        Id = 8,
                                        Name = "Esofman",
                                        CategoryGroup = new CategoryGroup
                                            {
                                                Id = 2,
                                                Name = "2",
                                                PriorityScore = 90
                                            },
                                         DivisionId = 1,
                                         CategoryGroupId = 2,
                                         PriorityScore = 90
                                    }
                            }
                    },
                new Division
                    {
                        Id = 2,
                        Name = "ERKEK",
                        PriorityScore = 90,
                        Categories = new List<Category>
                            {
                                new Category
                                    {
                                        Id = 9,
                                        Name = "Mont",
                                        CategoryGroup = new CategoryGroup
                                            {
                                                Id = 1,
                                                Name = "1",
                                                PriorityScore = 100
                                            },
                                         DivisionId = 2,
                                         CategoryGroupId = 1,
                                         PriorityScore = 100
                                    },
                                    new Category
                                    {
                                        Id = 10,
                                        Name = "Ceket",
                                        CategoryGroup = new CategoryGroup
                                            {
                                                Id = 1,
                                                Name = "1",
                                                PriorityScore = 100
                                            },
                                         DivisionId = 2,
                                         CategoryGroupId = 1,
                                         PriorityScore = 90
                                    },
                                    new Category
                                    {
                                        Id = 11,
                                        Name = "Smokin",
                                        CategoryGroup = new CategoryGroup
                                            {
                                                Id = 1,
                                                Name = "1",
                                                PriorityScore = 100
                                            },
                                         DivisionId = 2,
                                         CategoryGroupId = 1,
                                         PriorityScore = 70
                                    },
                                    new Category
                                    {
                                        Id = 12,
                                        Name = "Şort",
                                        CategoryGroup = new CategoryGroup
                                            {
                                                Id = 2,
                                                Name = "2",
                                                PriorityScore = 90
                                            },
                                         DivisionId = 2,
                                         CategoryGroupId = 1,
                                         PriorityScore = 50
                                    },
                                    new Category
                                    {
                                        Id = 13,
                                        Name = "Pantolon",
                                        CategoryGroup = new CategoryGroup
                                            {
                                                Id = 2,
                                                Name = "2",
                                                PriorityScore = 90
                                            },
                                         DivisionId = 2,
                                         CategoryGroupId = 2,
                                         PriorityScore = 100
                                    },
                                    new Category
                                    {
                                        Id = 14,
                                        Name = "Esofman",
                                        CategoryGroup = new CategoryGroup
                                            {
                                                Id = 2,
                                                Name = "2",
                                                PriorityScore = 90
                                            },
                                         DivisionId = 2,
                                         CategoryGroupId = 2,
                                         PriorityScore = 90
                                    },
                                    new Category
                                    {
                                        Id = 15,
                                        Name = "Kostum",
                                        CategoryGroup = new CategoryGroup
                                            {
                                                Id = 3,
                                                Name = "3",
                                                PriorityScore = 80
                                            },
                                         DivisionId = 2,
                                         CategoryGroupId = 3,
                                         PriorityScore = 100
                                    },
                                    new Category
                                    {
                                        Id = 16,
                                        Name = "Parti Giyim ve Aksesuar",
                                        CategoryGroup = new CategoryGroup
                                            {
                                                Id = 3,
                                                Name = "3",
                                                PriorityScore = 80
                                            },
                                         DivisionId = 2,
                                         CategoryGroupId = 3,
                                         PriorityScore = 90
                                    }
                            }
                    },
                    new Division
                    {
                        Id = 3,
                        Name = "COCUK",
                        PriorityScore = 80,
                        Categories = new List<Category>
                            {
                                new Category
                                    {
                                        Id = 17,
                                        Name = "Kiyafet",
                                        CategoryGroup = new CategoryGroup
                                            {
                                                Id = 1,
                                                Name = "1",
                                                PriorityScore = 100
                                            },
                                         DivisionId = 3,
                                         CategoryGroupId = 1,
                                         PriorityScore = 100
                                    },
                                    new Category
                                    {
                                        Id = 18,
                                        Name = "Mama Sandalyesi",
                                        CategoryGroup = new CategoryGroup
                                            {
                                                Id = 1,
                                                Name = "1",
                                                PriorityScore = 100
                                            },
                                         DivisionId = 3,
                                         CategoryGroupId = 1,
                                         PriorityScore = 90
                                    },
                                    new Category
                                    {
                                        Id = 19,
                                        Name = "Bebek Arabasi",
                                        CategoryGroup = new CategoryGroup
                                            {
                                                Id = 1,
                                                Name = "1",
                                                PriorityScore = 100
                                            },
                                         DivisionId = 3,
                                         CategoryGroupId = 1,
                                         PriorityScore = 70
                                    }
                            }
                    }
            };

        #endregion Divisions

        #region MockedProducts

        private static readonly IEnumerable<Product> Products = new List<Product>
            {
                new Product
                    {
                        Id = 1,
                        DaysSincePosted = 3,
                        Owner = "Hakan Tuncer",
                        ImageWidth = 197,
                        ImageHeight = 112,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/ea6419aa02dadc275dd61abadcc1f5b6b0e3b549.jpg",
                        Name = "Test Product",
                        Price = new decimal(12.50),
                        LikeCount = 22,
                        CategoryId = 1
                    },
                new Product
                    {
                        Id = 2,
                        DaysSincePosted = 3,
                        Owner = "Hakan Tuncer",
                        ImageWidth = 192,
                        ImageHeight = 266,
                        ImageUrl =
                            "http://media-cache-ec5.pinterest.com/upload/65372632061296806_USPDUZ5P_b.jpg",
                        Name = "Spangles and Gilding_Test",
                        Price = new decimal(17.09),
                        LikeCount = 12,
                        CategoryId = 1
                    },
                new Product
                    {
                        Id = 3,
                        DaysSincePosted = 5,
                        Owner = "Burcu Yuroglu",
                        ImageWidth = 197,
                        ImageHeight = 112,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/8b9b58c666c6967fd7c88725ac6a02a425373b47.jpg",
                        Name = "Nice Short",
                        Price = new decimal(37.50),
                        LikeCount = 12,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 4,
                        DaysSincePosted = 5,
                        Owner = "Burcu Yuroglu",
                        ImageWidth = 197,
                        ImageHeight = 197,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/234601caafd4d73e3fd140376543c28088b6f57d.jpg",
                        Name = "Nice Short",
                        Price = new decimal(37.50),
                        LikeCount = 12,
                        CategoryId = 1
                    }
                    ,
                    new Product
                    {
                        Id = 5,
                        DaysSincePosted = 5,
                        Owner = "Burcu Yuroglu",
                        ImageWidth = 197,
                        ImageHeight = 227,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/fe8929e41fbd03e07b8e11eec840174248b1f227.jpg",
                        Name = "Nice Short",
                        Price = new decimal(37.50),
                        LikeCount = 12,
                        CategoryId = 1
                    }
                    ,
                    new Product
                    {
                        Id = 6,
                        DaysSincePosted = 6,
                        Owner = "Cemal Dalar",
                        ImageWidth = 197,
                        ImageHeight = 112,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/93e15d60c92209d27692a058e1b1dec963c97873.jpg",
                        Name = "Not in Autumn",
                        Price = new decimal(37.50),
                        LikeCount = 12,
                        CategoryId = 1
                    }
                    ,
                    new Product
                    {
                        Id = 7,
                        DaysSincePosted = 2,
                        Owner = "Burcu Yuroglu",
                        ImageWidth = 197,
                        ImageHeight = 197,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/4d84fc314c327d1b97837c881a5fb7494398c326.jpg",
                        Name = "Nice Short",
                        Price = new decimal(37.50),
                        LikeCount = 12,
                        CategoryId = 1
                    }
                    ,
                    new Product
                    {
                        Id = 8,
                        DaysSincePosted = 3,
                        Owner = "Michael Jackson",
                        ImageWidth = 197,
                        ImageHeight = 200,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/4848519241c28b640dc0aa32d0da39b89e093fa8.jpg",
                        Name = "Nice Short",
                        Price = new decimal(37.50),
                        LikeCount = 12,
                        CategoryId = 1
                    }
                    ,
                    new Product
                    {
                        Id = 9,
                        DaysSincePosted = 5,
                        Owner = "Jack Daniels",
                        ImageWidth = 197,
                        ImageHeight = 185,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/fb35312c53135e77b5ca57c10738e2619520238a.jpg",
                        Name = "Nice Short",
                        Price = new decimal(37.50),
                        LikeCount = 12,
                        CategoryId = 1
                    }
                    ,
                    new Product
                    {
                        Id = 10,
                        DaysSincePosted = 8,
                        Owner = "John Smith",
                        ImageWidth = 197,
                        ImageHeight = 197,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/7f314c82e0ca5d8701f26b7bbc4820c293a10c68.jpg",
                        Name = "Girly top",
                        Price = new decimal(37.50),
                        LikeCount = 12,
                        CategoryId = 1
                    }
                    ,
                    new Product
                    {
                        Id = 11,
                        DaysSincePosted = 5,
                        Owner = "Burcu Yuroglu",
                        ImageWidth = 197,
                        ImageHeight = 88,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/0ed28c075f376e855282660df9f0cf1b04dcb38d.jpg",
                        Name = "Nice Short",
                        Price = new decimal(37.50),
                        LikeCount = 12,
                        CategoryId = 1
                    }
                    ,
                    new Product
                    {
                        Id = 12,
                        DaysSincePosted = 5,
                        Owner = "Burcu Yuroglu",
                        ImageWidth = 197,
                        ImageHeight = 147,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/b98d2b275c971f43cbf310ccde103d04ecedb0d5.jpg",
                        Name = "Nice Short",
                        Price = new decimal(37.50),
                        LikeCount = 12,
                        CategoryId = 1
                    }
                    ,
                    new Product
                    {
                        Id = 13,
                        DaysSincePosted = 5,
                        Owner = "Burcu Yuroglu",
                        ImageWidth = 197,
                        ImageHeight = 263,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/870e3d10e11eee4863ebe02dbc9f82a1ddd20c7d.jpg",
                        Name = "Nice Short",
                        Price = new decimal(37.50),
                        LikeCount = 12,
                        CategoryId = 1
                    }
                    ,
                    new Product
                    {
                        Id = 14,
                        DaysSincePosted = 5,
                        Owner = "Burcu Yuroglu",
                        ImageWidth = 197,
                        ImageHeight = 229,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/829211d3abc7124372e2086d51b39f446237c7a1.jpg",
                        Name = "Nice Short",
                        Price = new decimal(37.50),
                        LikeCount = 12,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 15,
                        DaysSincePosted = 5,
                        Owner = "Burcu Yuroglu",
                        ImageWidth = 197,
                        ImageHeight = 196,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/c92bf76c4337ea6965dd5bf6f8cef00bae1d7d2f.jpg",
                        Name = "Nice Short",
                        Price = new decimal(37.50),
                        LikeCount = 0,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 16,
                        DaysSincePosted = 5,
                        Owner = "Burcu Yuroglu",
                        ImageWidth = 197,
                        ImageHeight = 197,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/c885cf04b91df0e49ae9024cec1abc468399f726.jpg",
                        Name = "Nice Short",
                        Price = new decimal(37.50),
                        LikeCount = 7,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 17,
                        DaysSincePosted = 5,
                        Owner = "Burcu Yuroglu",
                        ImageWidth = 197,
                        ImageHeight = 196,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/ec008f7828987c05ee204e2c0363c6a1ac3fa89a.jpg",
                        Name = "Nice Short",
                        Price = new decimal(37.50),
                        LikeCount = 55,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 18,
                        DaysSincePosted = 5,
                        Owner = "Burcu Yuroglu",
                        ImageWidth = 197,
                        ImageHeight = 196,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/e2bd13d3ad989f7e161fcedd5606b7ebbef95481.jpg",
                        Name = "Nice Short",
                        Price = new decimal(2.50),
                        LikeCount = 0,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 19,
                        DaysSincePosted = 3,
                        Owner = "Hakan Tuncer",
                        ImageWidth = 197,
                        ImageHeight = 112,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/ea6419aa02dadc275dd61abadcc1f5b6b0e3b549.jpg",
                        Name = "Test Product",
                        Price = new decimal(12.50),
                        LikeCount = 22,
                        CategoryId = 1
                    },
                new Product
                    {
                        Id = 20,
                        DaysSincePosted = 3,
                        Owner = "Hakan Tuncer",
                        ImageWidth = 192,
                        ImageHeight = 266,
                        ImageUrl =
                            "http://media-cache-ec5.pinterest.com/upload/65372632061296806_USPDUZ5P_b.jpg",
                        Name = "Spangles and Gilding_Test",
                        Price = new decimal(17.09),
                        LikeCount = 12,
                        CategoryId = 1
                    },
                new Product
                    {
                        Id = 21,
                        DaysSincePosted = 5,
                        Owner = "Burcu Yuroglu",
                        ImageWidth = 197,
                        ImageHeight = 112,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/8b9b58c666c6967fd7c88725ac6a02a425373b47.jpg",
                        Name = "Nice Short",
                        Price = new decimal(37.50),
                        LikeCount = 12,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 22,
                        DaysSincePosted = 5,
                        Owner = "Burcu Yuroglu",
                        ImageWidth = 197,
                        ImageHeight = 197,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/234601caafd4d73e3fd140376543c28088b6f57d.jpg",
                        Name = "Nice Short",
                        Price = new decimal(37.50),
                        LikeCount = 12,
                        CategoryId = 1
                    }
                    ,
                    new Product
                    {
                        Id = 23,
                        DaysSincePosted = 5,
                        Owner = "Burcu Yuroglu",
                        ImageWidth = 197,
                        ImageHeight = 227,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/fe8929e41fbd03e07b8e11eec840174248b1f227.jpg",
                        Name = "Nice Short",
                        Price = new decimal(37.50),
                        LikeCount = 12,
                        CategoryId = 1
                    }
                    ,
                    new Product
                    {
                        Id = 24,
                        DaysSincePosted = 6,
                        Owner = "Cemal Dalar",
                        ImageWidth = 197,
                        ImageHeight = 112,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/93e15d60c92209d27692a058e1b1dec963c97873.jpg",
                        Name = "Not in Autumn",
                        Price = new decimal(37.50),
                        LikeCount = 12,
                        CategoryId = 1
                    }
                    ,
                    new Product
                    {
                        Id = 25,
                        DaysSincePosted = 2,
                        Owner = "Burcu Yuroglu",
                        ImageWidth = 197,
                        ImageHeight = 197,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/4d84fc314c327d1b97837c881a5fb7494398c326.jpg",
                        Name = "Nice Short",
                        Price = new decimal(37.50),
                        LikeCount = 12,
                        CategoryId = 1
                    }
                    ,
                    new Product
                    {
                        Id = 26,
                        DaysSincePosted = 3,
                        Owner = "Michael Jackson",
                        ImageWidth = 197,
                        ImageHeight = 200,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/4848519241c28b640dc0aa32d0da39b89e093fa8.jpg",
                        Name = "Nice Short",
                        Price = new decimal(37.50),
                        LikeCount = 12,
                        CategoryId = 1
                    }
                    ,
                    new Product
                    {
                        Id = 27,
                        DaysSincePosted = 5,
                        Owner = "Jack Daniels",
                        ImageWidth = 197,
                        ImageHeight = 185,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/fb35312c53135e77b5ca57c10738e2619520238a.jpg",
                        Name = "Nice Short",
                        Price = new decimal(37.50),
                        LikeCount = 12,
                        CategoryId = 1
                    }
                    ,
                    new Product
                    {
                        Id = 28,
                        DaysSincePosted = 8,
                        Owner = "John Smith",
                        ImageWidth = 197,
                        ImageHeight = 197,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/7f314c82e0ca5d8701f26b7bbc4820c293a10c68.jpg",
                        Name = "Girly top",
                        Price = new decimal(37.50),
                        LikeCount = 12,
                        CategoryId = 1
                    }
                    ,
                    new Product
                    {
                        Id = 29,
                        DaysSincePosted = 5,
                        Owner = "Burcu Yuroglu",
                        ImageWidth = 197,
                        ImageHeight = 88,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/0ed28c075f376e855282660df9f0cf1b04dcb38d.jpg",
                        Name = "Nice Short",
                        Price = new decimal(37.50),
                        LikeCount = 12,
                        CategoryId = 1
                    }
                    ,
                    new Product
                    {
                        Id = 30,
                        DaysSincePosted = 5,
                        Owner = "Burcu Yuroglu",
                        ImageWidth = 197,
                        ImageHeight = 147,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/b98d2b275c971f43cbf310ccde103d04ecedb0d5.jpg",
                        Name = "Nice Short",
                        Price = new decimal(37.50),
                        LikeCount = 12,
                        CategoryId = 1
                    }
                    ,
                    new Product
                    {
                        Id = 31,
                        DaysSincePosted = 5,
                        Owner = "Burcu Yuroglu",
                        ImageWidth = 197,
                        ImageHeight = 263,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/870e3d10e11eee4863ebe02dbc9f82a1ddd20c7d.jpg",
                        Name = "Nice Short",
                        Price = new decimal(37.50),
                        LikeCount = 12,
                        CategoryId = 1
                    }
                    ,
                    new Product
                    {
                        Id = 32,
                        DaysSincePosted = 5,
                        Owner = "Burcu Yuroglu",
                        ImageWidth = 197,
                        ImageHeight = 229,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/829211d3abc7124372e2086d51b39f446237c7a1.jpg",
                        Name = "Nice Short",
                        Price = new decimal(37.50),
                        LikeCount = 12,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 33,
                        DaysSincePosted = 5,
                        Owner = "Burcu Yuroglu",
                        ImageWidth = 197,
                        ImageHeight = 196,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/c92bf76c4337ea6965dd5bf6f8cef00bae1d7d2f.jpg",
                        Name = "Nice Short",
                        Price = new decimal(37.50),
                        LikeCount = 0,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 34,
                        DaysSincePosted = 5,
                        Owner = "Burcu Yuroglu",
                        ImageWidth = 197,
                        ImageHeight = 197,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/c885cf04b91df0e49ae9024cec1abc468399f726.jpg",
                        Name = "Nice Short",
                        Price = new decimal(37.50),
                        LikeCount = 7,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 35,
                        DaysSincePosted = 5,
                        Owner = "Burcu Yuroglu",
                        ImageWidth = 197,
                        ImageHeight = 196,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/ec008f7828987c05ee204e2c0363c6a1ac3fa89a.jpg",
                        Name = "Nice Short",
                        Price = new decimal(37.50),
                        LikeCount = 55,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 36,
                        DaysSincePosted = 5,
                        Owner = "Burcu Yuroglu",
                        ImageWidth = 197,
                        ImageHeight = 196,
                        ImageUrl =
                            "http://media.feedfloyd.com/post/thumb-1/e2bd13d3ad989f7e161fcedd5606b7ebbef95481.jpg",
                        Name = "Nice Short",
                        Price = new decimal(2.50),
                        LikeCount = 0,
                        CategoryId = 1
                    }
            };

        #endregion MockedProducts

        public static void InitializeDatabase()
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<EtiketiUstundeDbContext>()
                );

            using (var context = new EtiketiUstundeDbContext())
            {
                foreach (var division in Divisons)
                {
                    context.Divisions.AddOrUpdate(division);
                    foreach (var category in division.Categories)
                    {
                        context.CategoryGroups.AddOrUpdate(category.CategoryGroup);
                        context.Categories.AddOrUpdate(category);
                    }
                }

                context.SaveChanges();

                foreach (var product in Products)
                    context.Products.AddOrUpdate(product);

                context.SaveChanges();
            }
        }
    }
}
