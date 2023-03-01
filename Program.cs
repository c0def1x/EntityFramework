using Entity_Framework.Models;

Seeder.InitialSeed();

var context = new BlogContext();
foreach (Post post in context.Posts)
{
    Console.WriteLine($"=={post.Title}==");
    Console.WriteLine(post.Text);
    Console.WriteLine(post.PublicationTime);
}
