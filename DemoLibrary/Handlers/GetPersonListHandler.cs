using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using DemoLibrary.DataAcces;

namespace DemoLibrary.Handlers
{
    // This class is for handling our queries
    // When we implament the interface it's gonna add the handle method
    public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<PersonModel>>
    {
        private readonly IDataAccess _data;

        // This is dependency inyection
        // Mediatr doesn't replace dependency inyection, it just adds to it or improves it
        public GetPersonListHandler(IDataAccess data)
        {
            _data = data;
        }

        // You pass your request
        // Everything is asyncronous in mediator
        // Cancellation Token is optional
        // Handlers are the only 
        // The Task class represents a single operation that does not return a value and that usually executes asynchronously.
        public Task<List<PersonModel>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetPeople());
        }
    }
}
