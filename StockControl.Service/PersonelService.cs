﻿using StockControl.Data;
using StockControl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Service
{
	public class PersonelService : IPersonelService
	{
		private readonly IUnitOfWork unitOfWork;
		private readonly IRepository<Personel> personelRepository;

		public PersonelService(IUnitOfWork unitOfWork, IRepository<Personel> personelRepository)
		{
			this.unitOfWork = unitOfWork;
			this.personelRepository = personelRepository;
		}

		public void Delete(int id)
		{
			var personel = personelRepository.Get(id);
			if (personel != null)
			{
				personelRepository.Delete(personel);
				unitOfWork.SaveChanges();
			}
		}

		public Personel Get(int id)
		{
			return personelRepository.Get(id);

		}

		public IEnumerable<Personel> GetAll()
		{
			return personelRepository.GetAll();
		}

		public void Insert(Personel personel)
		{
			personelRepository.Insert(personel);
			unitOfWork.SaveChanges();
		}

		public void Update(Personel personel)
		{
			personelRepository.Update(personel);
			unitOfWork.SaveChanges();
		}

		public RegisterStatus Register(Personel personel)		{
			
			
			if (string.IsNullOrEmpty(personel.IdentityNumber.ToString()))
			{
				return RegisterStatus.InvalidField;
			}
			else
			{
				var newuser = personelRepository.Get(x => x.IdentityNumber == personel.IdentityNumber);
				if (newuser != null)
				{
					return RegisterStatus.UserAlreadyExists;
				}


			}

			personelRepository.Insert(personel);
			unitOfWork.SaveChanges();
			return RegisterStatus.Success;
		}

		public Personel Login(string identityNumber, string password)
		{
			
			var user = personelRepository.Get(x => x.IdentityNumber == identityNumber && x.Password == password);
			return user;
		}
	}

	public interface IPersonelService
	{
		void Insert(Personel personel);
		void Update(Personel personel);
		void Delete(int id);
		IEnumerable<Personel> GetAll();
		Personel Get(int id);
		RegisterStatus Register(Personel personel);
		Personel Login(string userName, string password);
	}

	public enum RegisterStatus
	{
		Success = 1,
		InvalidField = 2,
		UserAlreadyExists = 3
	}
}
