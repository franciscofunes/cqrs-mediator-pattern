using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Queries
{
    // This data we're passing in and also how I'll identify what the handler is
    // Records are inmutable by default that's one of the features
    public record GetPersonListQuery() : IRequest<List<PersonModel>>;

    // Class implementation alternative
    //public class GetPersonListQueryClass : IRequest<List<PersonModel>>;


}
