using MySoft.Entity.Master;
using MySoft.Entity;
using Microsoft.EntityFrameworkCore;

namespace MySoft.Service.Master
{
    #region ChangeCode
    public interface ICountryService
    {
        Task<List<Country>> GetALLCountryAsync();
        Task<Country> GetCountryAsync(int Id);
        Task<string> SaveCountryAsync(Country model);
        Task<string> DeleteCountryAsync(int Id);
    }
    #endregion




    public class CountryService : ICountryService
    {
        #region ChangeCode



        #region Constructor
        private readonly AppDbContext _context;
        public CountryService(AppDbContext context)
        {
            this._context = context;
        }
        #endregion



        public async Task<List<Country>> GetALLCountryAsync()
        {
            List<Country> lstCountry = new List<Country>();
            try
            {
                lstCountry=await _context.Country.ToListAsync();
            }
            catch (Exception)
            {
                lstCountry=new List<Country>();
            }

            return lstCountry;
        }

        public async Task<Country> GetCountryAsync(int Id)
        {

            Country ObjCountry = new Country();
            try
            {
                //Search object in DB to delete
                ObjCountry=await _context.Country.FindAsync(Id); ;
            }
            catch (Exception)
            {
                ObjCountry = new Country();
            }

            return ObjCountry;
        }

        public async Task<string> SaveCountryAsync(Country model)
        {
            string responseMsg = string.Empty;
            try
            {
                if (model.Id>0)
                {
                    _context.Country.Update(model);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    _context.Country.Add(model);
                    await _context.SaveChangesAsync();
                }


                responseMsg="success";
            }
            catch (Exception ex)
            {
                responseMsg=ex.Message;
            }

            return responseMsg;
        }

        public async Task<string> DeleteCountryAsync(int Id)
        {

            string responseMsg = string.Empty;
            try
            {
                //Search object in DB to delete
                Country ObjCountry = await _context.Country.FindAsync(Id);

                if (ObjCountry!=null)
                {
                    _context.Country.Remove(ObjCountry);
                    _context.SaveChanges();
                    responseMsg="success";
                }
                else
                {
                    responseMsg="error";
                }

            }
            catch (Exception ex)
            {
                responseMsg=ex.Message;
            }

            return responseMsg;
        }

        #endregion
    }
}
