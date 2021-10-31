using System;
using System.Threading.Tasks;
using AutoMapper;
using MassTransitTutorial.Domain;
using MassTransitTutorial.Domain.Customer;
using Microsoft.EntityFrameworkCore;

namespace MassTransitTutorial.Persistence
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerContext _context;
        private readonly IMapper _mapper;

        public CustomerRepository(CustomerContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CustomerEntity> CreateCustomer(NewCustomer customer)
        {
            var entity = _mapper.Map<TbCustomer>(customer);
            _context.Customers.Add(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<CustomerEntity>(entity);
        }

        public async Task ChangeBirthDate(CustomerEntity customer)
        {
            var entity = await _context.Customers.SingleOrDefaultAsync(c => c.Id == Guid.Parse(customer.CustomerId.Id));

            if (entity != null)
            {
                entity.BirthDate = customer.BirthDate;
                entity.UpdatedAt = customer.UpdatedAt;

                await _context.SaveChangesAsync();
            }
        }

        public async Task<CustomerEntity> WithId(CustomerId customerId)
        {
            var entity = await _context.Customers.SingleOrDefaultAsync(c => c.Id == Guid.Parse(customerId.Id));
            return _mapper.Map<CustomerEntity>(entity) ?? CustomerEntity.Empty;
        }
    }
}