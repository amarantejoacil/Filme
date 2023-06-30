using AutoMapper;
using FilmesAPI.Data.Dtos.Cinema;
using FilmesAPI.Models;



namespace FilmesAPI.Profiles
{
    public class CinemaProfile : Profile
    {

        public CinemaProfile()
        {
            //quando estamos criando mapeamos dto primeiro
            CreateMap<CreateCinemaDto, Cinema>();
            // quando estamos buscando mapeamos entidade para read
            //CreateMap<Cinema, ReadCinemaDto>(); //antes

            CreateMap<Cinema, ReadCinemaDto>().ForMember(cinameDto => cinameDto.Endereco,
                opt => opt.MapFrom(cinema => cinema.Endereco));
            //Convernteo Cinema para ReadCinemaDto
            //para meu paco de destino "ReadCinemaDto", eu quero pegar na origem "Cinema"o campo de ENDERECO. 


            CreateMap<UpdateCinemaDto, Cinema>();
        }

    }
}
