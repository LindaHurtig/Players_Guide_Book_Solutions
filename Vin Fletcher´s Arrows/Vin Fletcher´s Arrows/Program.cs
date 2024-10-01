

Console.WriteLine("What arrow do you want?");
Console.WriteLine("[1] Elite arrow");
Console.WriteLine("[2] Beginners arrow");
Console.WriteLine("[3] Marksman arrow");
Console.WriteLine("[4] Costum made arrow");

string choice = Console.ReadLine();



Arrow arrow = choice switch
{
    "1" => Arrow.CreateElitArrow(),
    "2" => Arrow.CreateBeginnerArrow(),
    "3" => Arrow.CreateMarksmanArrow(),
    _ => CreateCustomArrow() 

};


Console.WriteLine($"Your arrow will cost {arrow.Cost}gold");
Arrow CreateCustomArrow()
{
    ArrowheadType arrowhead = GetArrowheadType();
    FletchingType fletchingType = GetFletchingType();
    int shaftLength = GetShaftLength();

    return new Arrow(arrowhead, fletchingType, shaftLength);
}


ArrowheadType GetArrowheadType()
{
    Console.Write("What arrowhead to you want (steel, wood, obsidian)");
    string arrowheadInput = Console.ReadLine();

    return arrowheadInput switch
    {
        "steel" => ArrowheadType.steel,
        "wood" => ArrowheadType.wood,
        "obsidian" => ArrowheadType.obsidian
    };
}

FletchingType GetFletchingType()
{
    Console.WriteLine("What fletching type do you want (plastic, turkey feathers, goose feathers)");
    string fletchingInput = Console.ReadLine();

    return fletchingInput switch
    {
        "plastic" => FletchingType.plastic,
        "turkey feathers" => FletchingType.turkeyFeathers,
        "goose feathers" => FletchingType.gooseFeathers
    };
}

int GetShaftLength()
{
    Console.Write("How long do you want your arrow to be (60-100cm)");
    int arrowLength = Convert.ToInt32(Console.ReadLine());

    return arrowLength;
}



class Arrow
{
    private ArrowheadType ArrowheadType { get;}
    private FletchingType FletchingType { get;}
    private int ShaftLength { get; }

    public Arrow(ArrowheadType arrowhead, FletchingType fletchingType, int shaftLength)
    {
        ArrowheadType = arrowhead;
        FletchingType = fletchingType;
        ShaftLength = shaftLength;
    }

    public float Cost {
        get
        {
            float arrowheadCost = ArrowheadType switch
            {
                ArrowheadType.steel => 10,
                ArrowheadType.wood => 3,
                ArrowheadType.obsidian => 5,
            };

            float arrowfletchCost = FletchingType switch
            {
                FletchingType.plastic => 10,
                FletchingType.turkeyFeathers => 5,
                FletchingType.gooseFeathers => 3,
            };

            float arrowLengthCost = ShaftLength * 0.05f;
    

            return arrowheadCost + arrowfletchCost + arrowLengthCost;
        }
    }

    public static Arrow CreateElitArrow() => new Arrow (ArrowheadType.steel, FletchingType.plastic, 95);
    public static Arrow CreateBeginnerArrow() => new Arrow(ArrowheadType.wood, FletchingType.gooseFeathers, 75);
    public static Arrow CreateMarksmanArrow() => new Arrow(ArrowheadType.steel, FletchingType.gooseFeathers, 65);
}

enum ArrowheadType {steel, wood, obsidian}
enum FletchingType {plastic, turkeyFeathers, gooseFeathers }
