// Creating the item class
class Item {
    // Public properties for giving weight and value
    public int Weight { get; private set; }

    public int Value { get; private set; }

    // Finding the ValuePerWeight :
    public int ValuePerWeight {
        get {
            return Value / Weight;
        }
    }

    // Building the constructor
    public Item(int w, int v) {
        Weight = w;
        Value = v;
    }

    public override string ToString() {
        return $"W:{Weight} V:{Value} V/W:{ValuePerWeight}";
    }
}
class NapSack {
    List<Item> Items = new List<Item>();

    // Adding the items Item(weight,value)
    //Items.Add(new Item(7, 42));
    //Items.Add(new Item(3, 12));
    //Items.Add(new Item(4, 40));
    //Items.Add(new Item(5, 25));

    // Weight Left on the backpack - 10 by default
    int bpWeightLeft = 10;

    // List of the items inside the backpack
    List<Item> Backpack = new List<Item>();

    // List of the Items that can get in the backpack (Sorted)
    List<Item> available = new List<Item>();

    void GetAnswer() {
        available.AddRange(Items.OrderByDescending(item => item.ValuePerWeight).ThenBy(item => item.Weight));

        // Looping while there are items in available
        while (available.Count > 0 && bpWeightLeft > 0) {
            Backpack.Add(available[0]);
            Items.Remove(available[0]);

            bpWeightLeft -= available[0].Weight;

            available = Items.Where(item => item.Weight <= bpWeightLeft)
                        .OrderByDescending(item => item.ValuePerWeight)
                        .ThenBy(item => item.Weight)
                        .ToList();
        }


        Console.WriteLine(String.Join("\n", Backpack));
        Console.WriteLine($"Total Weight: {Backpack.Sum(item => item.Weight)}");
        Console.WriteLine($"Total Value: {Backpack.Sum(item => item.Value)}");
    }
}