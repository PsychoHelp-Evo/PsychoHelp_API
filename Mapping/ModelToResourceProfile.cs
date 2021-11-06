﻿using AutoMapper;
using PsychoHelp_API.Psychologists.Domain.Model;
using PsychoHelp_API.Psychologists.Resources;
using PsychoHelp_API.patients.Domain.Models;
using PsychoHelp_API.patients.Resources;

namespace PsychoHelp_API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Psychologist, PsychologistResource>();
            CreateMap<Patient, PatientResource>();
            CreateMap<Logbook, LogBookResource>();
        }
    }
}
