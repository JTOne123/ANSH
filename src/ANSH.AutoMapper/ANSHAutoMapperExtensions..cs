using System;
using AutoMapper;

/// <summary>
/// 扩展方法
/// </summary>
public static class ANSHAutoMapperExtensions {

    /// <summary>
    /// 转换类型
    /// </summary>
    /// <param name="value">源数据</param>
    /// <typeparam name="TDirection">转换后的类型</typeparam>
    /// <returns>转换后的数据</returns>
    public static TDirection ANSHMapperTo<TDirection> (this object value) => Mapper.Map<object, TDirection> (value);

    /// <summary>
    /// 转换类型
    /// </summary>
    /// <param name="value">源数据</param>
    /// <param name="direction">需合并的数据</param>
    /// <typeparam name="TDirection">转换后的类型</typeparam>
    /// <returns>转换后的数据</returns>
    public static TDirection ANSHMapperTo<TDirection> (this object value, TDirection direction) => Mapper.Map<object, TDirection> (value, direction);

}

/// <summary>
/// AutoMapper
/// </summary>
public static class ANSHAutoMapper {
    /// <summary>
    /// AutoMapper全局配置
    /// </summary>
    /// <param name="config">配置信息</param>
    public static void Initialize (Action<IMapperConfigurationExpression> config) {
        Mapper.Initialize (m => {
            m.ClearPrefixes ();
            m.AddProfile<TypeConverterProfile> ();
            config (m);
        });
        Mapper.AssertConfigurationIsValid ();
    }
}

class TypeConverterProfile : Profile,
    ITypeConverter<string, Nullable<int>>,
    ITypeConverter<Nullable<int>, string>,

    ITypeConverter<string, Nullable<DateTime>>,
    ITypeConverter<Nullable<DateTime>, string>,

    ITypeConverter<string, Nullable<bool>>,
    ITypeConverter<Nullable<bool>, string>,

    ITypeConverter<string, Nullable<Guid>>,
    ITypeConverter<Nullable<Guid>, string>,

    ITypeConverter<long, Nullable<DateTime>>,
    ITypeConverter<Nullable<DateTime>, long>,

    ITypeConverter<double, Nullable<DateTime>>,
    ITypeConverter<Nullable<DateTime>, double> {

        public TypeConverterProfile () {
            CreateMap<string, Nullable<int>> ().ConvertUsing<TypeConverterProfile> ();
            CreateMap<Nullable<int>, string> ().ConvertUsing<TypeConverterProfile> ();

            CreateMap<string, Nullable<DateTime>> ().ConvertUsing<TypeConverterProfile> ();
            CreateMap<Nullable<DateTime>, string> ().ConvertUsing<TypeConverterProfile> ();

            CreateMap<string, Nullable<bool>> ().ConvertUsing<TypeConverterProfile> ();
            CreateMap<Nullable<bool>, string> ().ConvertUsing<TypeConverterProfile> ();

            CreateMap<string, Nullable<Guid>> ().ConvertUsing<TypeConverterProfile> ();
            CreateMap<Nullable<Guid>, string> ().ConvertUsing<TypeConverterProfile> ();

            CreateMap<long, Nullable<DateTime>> ().ConvertUsing<TypeConverterProfile> ();
            CreateMap<Nullable<DateTime>, long> ().ConvertUsing<TypeConverterProfile> ();

            CreateMap<double, Nullable<DateTime>> ().ConvertUsing<TypeConverterProfile> ();
            CreateMap<Nullable<DateTime>, double> ().ConvertUsing<TypeConverterProfile> ();
        }
        public int? Convert (string source, int? destination, ResolutionContext context) => int.TryParse (source, out int result) ? (int?) result : null;

        public DateTime? Convert (string source, DateTime? destination, ResolutionContext context) => DateTime.TryParse (source, out DateTime result) ? (DateTime?) result : null;

        public string Convert (int? source, string destination, ResolutionContext context) => source?.ToString () ?? string.Empty;

        public string Convert (DateTime? source, string destination, ResolutionContext context) => source?.ToString ("yyyy-MM-dd HH:mm:ss") ?? "1970-0-0 00:00:00";

        public string Convert (bool? source, string destination, ResolutionContext context) => source.HasValue? string.Empty : source.Value? "true": "false";

        public bool? Convert (string source, bool? destination, ResolutionContext context) => bool.TryParse (source, out bool result) ? (bool?) result : null;

        public Guid? Convert (string source, Guid? destination, ResolutionContext context) => Guid.TryParse (source, out Guid result) ? (Guid?) result : null;

        public string Convert (Guid? source, string destination, ResolutionContext context) => source?.ToString () ?? string.Empty;

        public DateTime? Convert (long source, DateTime? destination, ResolutionContext context) => source.IsTimeStamp (out DateTime result) ? (DateTime?) result : null;

        public long Convert (DateTime? source, long destination, ResolutionContext context) => source.HasValue?(long) source.Value.ToTimeStamp () : 0;

        public DateTime? Convert (double source, DateTime? destination, ResolutionContext context) => source.IsTimeStamp (out DateTime result) ? (DateTime?) result : null;

        public double Convert (DateTime? source, double destination, ResolutionContext context) => source.HasValue? source.Value.ToTimeStamp () : 0;
    }