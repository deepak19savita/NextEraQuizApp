using Entity;
using HomeCinema.Web.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NextEraQuizApp.Controller
{
    public class SubjectController : ApiControllerBase
    {

        private readonly QuizAppContext _EntityRepository = null;
        public SubjectController()
        {
            _EntityRepository = new QuizAppContext();

        }
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            //filter = filter.ToLower().Trim();
            string filter = string.Empty;


            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;

                var subjects = _EntityRepository.Subjects
                    .Where(c => c.SubjectName.ToLower().Contains(filter)).ToList<Subject>();

                //var customersVm = Mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerViewModel>>(customers);

                response = request.CreateResponse(HttpStatusCode.OK, subjects);

                return response;
            });
        }
        public HttpResponseMessage Put(HttpRequestMessage request)
        {
            //filter = filter.ToLower().Trim();
            string filter = string.Empty;


            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;

                var subjects = _EntityRepository.Subjects
                    .Where(c => c.SubjectName.ToLower().Contains(filter)).ToList<Subject>();

                response = request.CreateResponse(HttpStatusCode.OK, subjects);

                return response;
            });
        }
        
        public HttpResponseMessage Post(HttpRequestMessage request, Subject subject)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;

                if (!ModelState.IsValid)
                {
                    response = request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    Subject newSubject = new Subject();
                    _EntityRepository.Subjects.Add(subject);
                    _EntityRepository.SaveChanges();
                    response = request.CreateResponse(HttpStatusCode.Created, subject);
                }

                return response;
            });
        }
    }
}
