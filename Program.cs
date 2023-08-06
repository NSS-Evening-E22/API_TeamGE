using API_TeamGE.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
List<Reactions> reactionList = new List<Reactions> ()
{
    new Reactions
    {
        Id = 1,
        Emoji = "U+1F60D", //Face Love
    },      
    new Reactions
    {
        Id = 2,
        Emoji =  "U+1F914",  //Thinking Face
    },    
    new Reactions
    {
        Id = 3,
        Emoji = "U+1F92F",  //Mind Blowing
    },    
    new Reactions
    {
        Id = 4,
        Emoji = "U+1F621", // Angry Face
    },
};
List<PostReactions> PostReactionsList = new List<PostReactions>()
{
    new PostReactions 
    {
        Id = 1,
        ReactionId = 5,
        UserId = 2,
        PostId = 3,
    },    
    new PostReactions 
    {
        Id = 2,
        ReactionId = 4,
        UserId = 3,
        PostId = 4,
    },    
    new PostReactions 
    {
        Id = 3,
        ReactionId = 3,
        UserId = 4,
        PostId = 5,
    },    
    new PostReactions 
    {
        Id = 4,
        ReactionId = 2,
        UserId = 1,
        PostId = 2,
    },    
    new PostReactions 
    {
        Id = 5,
        ReactionId = 1,
        UserId = 5,
        PostId = 1,
    },
};

List<Comment> CommentList = new List<Comment>()
{
    new Comment()
    {
        Id = 1,
        AuthorId = 1,
        PostId= 1,
        Content="They aren't even close to \"Full self driving\", yet still call it that; fraudulent advertising at best. BTW, you'll get banned on reddit for mentioning that."
    },
    new Comment()
    {
        Id = 2,
        AuthorId = 3,
        PostId= 5,
        Content="Without a consumer-usable or at least visible AI assisting service in the OS, future improvements in hardware are going to be dismissed by consumers with two words: \"so what?\"."
    },
    new Comment()
    {
        Id = 3,
        AuthorId = 2,
        PostId= 2,
        Content="I somewhat agree, but I’m coming around to the idea of the Action Button. I like the mute switch but my phone is on silent 99.9% of the time, so the switch is pretty much useless now."
    },
    new Comment()
    {
        Id = 4,
        AuthorId = 4,
        PostId= 2,
        Content="Thanks for sharing these amazing insights!"
    }
};

List<Category> CategoryList = new List<Category>()
{
    new Category()
    {
        Id = 1,
        Label = "Web Development"
    },
    new Category()
    {
        Id = 2,
        Label = "CyberSecurity"
    },
    new Category()
    {
        Id = 3,
        Label = "AI/MachineLearning"
    },
    new Category()
    {
        Id = 4,
        Label = "Crypto/Web3"
    },
    new Category()
    {
        Id = 5,
        Label = "Tech Startups/Business"
    },
    new Category()
    {
        Id = 6,
        Label = "DevOps"
    },
};

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
