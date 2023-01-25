using E_Shop.Data.Static;
using E_Shop.Models;
using Microsoft.AspNetCore.Identity;

namespace E_Shop.Data
{
    public class ApplicationDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Современник",
                            ImgUrl = "https://sun9-north.userapi.com/sun9-86/s/v1/ig2/CHaAgf1EUENYZXE2iEqtDJtJsjJ2PSIEchcDXrMF_bvkDpCXEx8j-pbWTx-U7gqvSWKC9nyT2o1hOi9vP9uaDb10.jpg?size=300x300&quality=96&type=album",
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit."
                        },
                        new Cinema()
                        {
                            Name = "Capitol Cinema Company",
                            ImgUrl = "https://sun7.userapi.com/sun7-9/s/v1/ig2/NMRUIWh5rC-TO0kTtcbPB_P-MF2qeBE_Ao5dHxuF46qWmG4smgmxlZ2Xb9jzjT8EWqHgK6DDfNknH0BVxYIPQxRv.jpg?size=2418x2109&quality=96&type=album",
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit."
                        }
                    }
                    );
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            Name = "Uma Turman",
                            ImgUrl = "https://sun7.userapi.com/sun7-13/s/v1/ig2/tu0kSJhL0yiLFldg2gjlyB7B492VD8QKz0Pm2uIQFeEp44FYWvI_cIbuoXzjg6ZV46gOOpQxLWnE4brPTKPivBWk.jpg?size=1126x1500&quality=96&type=album",
                            Bio = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit."
                        },
                        new Actor()
                        {
                            Name = "Sam Jackson",
                            ImgUrl = "https://sun9-east.userapi.com/sun9-24/s/v1/ig2/GVdOgQrKT1TrKAV8soUpOIQ7P5txzaEawusDz-doAC8TURNC5dDC4l5yYLHT1xSoU9iczSigIL3C_KTKn1mf3AR6.jpg?size=885x1200&quality=96&type=album",
                            Bio = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit."
                        },
                        new Actor()
                        {
                            Name = "Elle Fanning",
                            ImgUrl = "https://sun9-west.userapi.com/sun9-4/s/v1/ig2/0XBKOua66kcFjhMBUXa_CseR5J3Wv99rgWoPLwmzzO6m0uIQKl678vD7oBvgkCvOJ8twLXOiLW8pQHuFxjL1gOZY.jpg?size=736x1028&quality=96&type=album",
                            Bio = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit."
                        }
                    }
                    );
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            Name = "Nicolas Refn",
                            ImgUrl = "https://sun9-west.userapi.com/sun9-67/s/v1/ig2/vGFDirWQceFK-TggXmN9KDxUd4PTmKMGUWuTXaqbeXA8CQUMxRfro-pdFqGbS6ZvpIZNTeOssnmVgVx0boU3bplL.jpg?size=1679x2160&quality=96&type=album",
                            Bio = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit."
                        },
                        new Producer()
                        {
                            Name = "Quentin Tarantino",
                            ImgUrl = "https://sun7.userapi.com/sun7-8/s/v1/ig2/G7ZN0WAJdEERvH2azCVbaSaQjhCRaBxIN8D91VPKJgEguE8bWtho4Rgqz5mZBC9e0pyNlZ_iqBsLiroWob6xxKM6.jpg?size=800x1183&quality=96&type=album",
                            Bio = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit."
                        },
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Neon Demon",
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.",
                            Price = 19.99,
                            ImgUrl = "https://sun9-north.userapi.com/sun9-82/s/v1/ig2/R1yzZjQYLRMSPfi12mgODiVXEMxMdCddNp8zoFTCBDwhLkDxGSsbLpHwvUuce2_Z-CPWsN7zgZKoCqTqSK1IQ3tD.jpg?size=1542x2160&quality=96&type=album",
                            DateReleased = "2016",
                            CinemaId = 2,
                            ProducerId = 1,
                            MovieCategory = Enums.MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Pulp Fiction",
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.",
                            Price = 9.99,
                            ImgUrl = "https://sun9-east.userapi.com/sun9-30/s/v1/ig2/jfa6RIAQmKmUPEQAnDpJjEQy3nNhWc0NqhIzQt2MGvSr0PrX00Zi4n5oGX3vSbAodMCQmhqJlpMGxpjK1dwN9s9S.jpg?size=1000x1362&quality=96&type=album",
                            DateReleased = "1994",
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = Enums.MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Kill Bill",
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.",
                            Price = 29.99,
                            ImgUrl = "https://sun9-west.userapi.com/sun9-8/s/v1/ig2/xXLXjrkC9Fo8uCWA2MmVFaTXHexs-iGSGxxmbqR7mr30qxGoB80JG2BUzWmQNy3uuswKH7YJoQRKB4ZDaq5DP2Ma.jpg?size=1537x2160&quality=96&type=album",
                            DateReleased = "2003",
                            CinemaId = 2,
                            ProducerId = 2,
                            MovieCategory = Enums.MovieCategory.Thriller
                        },
                    });
                    context.SaveChanges();
                }
                //Actors_Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                    });
                    context.SaveChanges();
                }

            }

        }
    
    public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
    {
        using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        {

            //Roles
            var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
            if (!await roleManager.RoleExistsAsync(UserRoles.User))
                await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

            //Users
            var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            string adminUserEmail = "admin@E_Shop.com";

            var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
            if (adminUser == null)
            {
                var newAdminUser = new ApplicationUser()
                {
                    FullName = "Admin User",
                    UserName = "admin-user",
                    Email = adminUserEmail,
                    EmailConfirmed = true
                };
                await userManager.CreateAsync(newAdminUser, "14881488!zZ");
                await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
            }


            string appUserEmail = "user@E_shop.com";

            var appUser = await userManager.FindByEmailAsync(appUserEmail);
            if (appUser == null)
            {
                var newAppUser = new ApplicationUser()
                {
                    FullName = "Application User",
                    UserName = "app-user",
                    Email = appUserEmail,
                    EmailConfirmed = true
                };
                await userManager.CreateAsync(newAppUser, "14881488!zZ");
                await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
            }
        }
    }
}}
