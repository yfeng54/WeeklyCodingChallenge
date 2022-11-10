
Console.WriteLine(Interview(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 120) == "qualified");// ➞ "qualified"

Console.WriteLine(Interview(new int[] { 2, 3, 8, 6, 5, 12, 10, 18 }, 64) == "qualified"); //➞  "qualified"

Console.WriteLine(Interview(new int[] { 5, 5, 10, 10, 25, 15, 20, 20 }, 120) == "disqualified"); //➞ "disqualified"

Console.WriteLine(Interview(new int[] { 5, 5, 10, 10, 15, 15, 20 }, 120) == "disqualified"); //➞ "disqualified"

Console.WriteLine(Interview(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 130) == "disqualified"); //➞ "disqualified"


string Interview(int[] questions, int total) {
    if(total > 120) {
        return "disqualified";
    }
    if(questions.Length != 8) {
        return "disqualified";
    }
    if (questions[0] > 5 || questions[0] < 0) {
        return "disqualified";
    }
    if (questions[1] > 5 || questions[1] < 0) {
        return "disqualified";
    }
    if (questions[2] > 10 || questions[2] < 0) {
        return "disqualified";
    }
    if (questions[3] > 10 || questions[3] < 0) {
        return "disqualified";
    }
    if (questions[4] > 15 || questions[4] < 0) {
        return "disqualified";
    }
    if (questions[5] > 15 || questions[5] < 0) {
        return "disqualified";
    }
    if (questions[6] > 20 || questions[6] < 0) {
        return "disqualified";
    }
    if (questions[7] > 20 || questions[7] < 0) {
        return "disqualified";
    }

    return "qualified";
}