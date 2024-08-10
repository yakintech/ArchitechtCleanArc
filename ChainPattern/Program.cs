

using ChainPattern.Models;

List<CreditAnswerBase> creditAnswerBases = new List<CreditAnswerBase>
{
    new CreditKKBScore(),
    new CreditSponsor(),
    new CreditTCControl()
};


creditAnswerBases[0].setNextHandler(creditAnswerBases[1]);
creditAnswerBases[1].setNextHandler(creditAnswerBases[2]);


Customer customer = new Customer
{
    KKBScore = 600,
    SponsorStatus = false,
    HasTCNo = true
};

creditAnswerBases[0].ExecuteHandler(customer);


bool creditResult = false;

// all creditAnswerBases should be approved
foreach (var creditAnswerBase in creditAnswerBases)
{
    if (!creditAnswerBase.IsApproved)
    {
        creditResult = false;
        break;
    }

    creditResult = true;
}


if (creditResult)
{
    Console.WriteLine("Credit is approved");
}
else
{
    Console.WriteLine("Credit is not approved");
}

Console.ReadLine();