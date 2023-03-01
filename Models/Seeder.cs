namespace Entity_Framework.Models
{
    public class Seeder
    {
        public static void InitialSeed()
        {
            using (var context = new BlogContext())
            {
                if (!context.Blogs.Any())
                {
                    Blog firstblog = new Blog
                    {
                        Title = "Кулинария от Василия",
                        Author = "Vasya@mail.com",
                        CreationDate = DateTime.Now.AddYears(-3),
                        Posts = new()
                    };
                    Blog secondblog = new Blog
                    {
                        Title = "Кулинария от Вики",
                        Author = "Vika@mail.com",
                        CreationDate = DateTime.Now.AddYears(-2),
                        Posts = new()
                    };
                    Blog thirdblog = new Blog
                    {
                        Title = "Блог без постов",
                        Author = "NoPosts@mail.com",
                        CreationDate = DateTime.Now.AddYears(-1),
                        Posts = new()
                    };
                    context.Blogs.Add(firstblog);
                    context.Blogs.Add(secondblog);
                    context.Blogs.Add(thirdblog);

                    firstblog.Posts?.Add(new Post
                    {
                        Title = "О себе",
                        Text = "Всем привет, я Вася-повар! В этом блоге я расскажу вам о многих интересных рецептах",
                        PublicationTime = DateTime.Now.AddDays(-41)
                    });
                    secondblog.Posts?.Add(new Post
                    {
                        Title = "О себе",
                        Text = "Всем привет, я Вика-повар! В этом блоге я расскажу вам о многих интересных рецептах",
                        PublicationTime = DateTime.Now.AddYears(-2)
                    });
                    firstblog.Posts?.Add(new Post
                    {
                        Title = "Яблочный пирог",
                        Text = "Всем привет, я Вася-повар! В этом блоге я расскажу вам о том, как испечь яблочный пирог",
                        PublicationTime = DateTime.Now.AddYears(-3)
                    });
                    secondblog.Posts?.Add(new Post
                    {
                        Title = "Ягодный пирог",
                        Text = "Всем привет, я Вика-повар! В этом блоге я расскажу вам о том, как испечь ягодный пирог",
                        PublicationTime = DateTime.Now.AddYears(-2)
                    });
                    firstblog.Posts?.Add(new Post
                    {
                        Title = "Пирожное",
                        Text = "Всем привет, я Вася-повар! В этом блоге я расскажу вам о том, как испечь пирожное",
                        PublicationTime = DateTime.Now.AddYears(-3)
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
