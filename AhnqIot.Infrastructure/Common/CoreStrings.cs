#region Code File Comment

// SOLUTION   ： 农业气象物联网V3
// PROJECT    ： AhnqIot.Infrastructure
// FILENAME   ： CoreStrings.cs
// AUTHOR     ： soft-cq
// CREATE TIME： 2016-01-12 18:40
// COPYRIGHT  ： 版权所有 (C) 物联网科技有限公司 http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace

using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;

#endregion

namespace AhnqIot.Infrastructure
{
    public static class CoreStrings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("AhnqIot.Infrastructure.CoreStrings", typeof (CoreStrings).GetTypeInfo().Assembly);

        /// <summary>
        ///     The provider for the source IQueryable doesn't implement IAsyncQueryProvider. Only providers that implement
        ///     IEntityQueryProvider can be used for Entity Framework asynchronous operations.
        /// </summary>
        public static string IQueryableProviderNotAsync
        {
            get { return GetString("IQueryableProviderNotAsync"); }
        }

        /// <summary>
        ///     No database providers are configured. Configure a database provider by overriding OnConfiguring in your DbContext
        ///     class or in the AddDbContext method when setting up services.
        /// </summary>
        public static string NoProviderConfigured
        {
            get { return GetString("NoProviderConfigured"); }
        }

        /// <summary>
        ///     No database providers are available. Ensure that database provider services are added inside the call to
        ///     AddEntityFramework on your ServiceCollection.
        /// </summary>
        public static string NoProviderServices
        {
            get { return GetString("NoProviderServices"); }
        }

        /// <summary>
        ///     The EF.Property&lt;T&gt; method may only be used within LINQ queries.
        /// </summary>
        public static string PropertyMethodInvoked
        {
            get { return GetString("PropertyMethodInvoked"); }
        }

        /// <summary>
        ///     The Include operator is not implemented by the current database provider.
        /// </summary>
        public static string IncludeNotImplemented
        {
            get { return GetString("IncludeNotImplemented"); }
        }

        /// <summary>
        ///     An attempt was made to use the model while it was being created. A DbContext instance cannot be used inside
        ///     OnModelCreating in any way that makes use of the model that is being created.
        /// </summary>
        public static string RecursiveOnModelCreating
        {
            get { return GetString("RecursiveOnModelCreating"); }
        }

        /// <summary>
        ///     An attempt was made to use the context while it is being configured. A DbContext instance cannot be used inside
        ///     OnConfiguring since it is still being configured at this point.
        /// </summary>
        public static string RecursiveOnConfiguring
        {
            get { return GetString("RecursiveOnConfiguring"); }
        }

        /// <summary>
        ///     The principal and dependent ends of the relationship cannot be flipped once foreign key or principal key properties
        ///     have been specified.
        /// </summary>
        public static string RelationshipCannotBeInverted
        {
            get { return GetString("RelationshipCannotBeInverted"); }
        }

        /// <summary>
        ///     An exception was thrown while attempting to evaluate a LINQ query parameter expression. To show aditional
        ///     information call EnableSensitiveDataLogging() when overriding DbContext.OnConfiguring.
        /// </summary>
        public static string ExpressionParameterizationException
        {
            get { return GetString("ExpressionParameterizationException"); }
        }

        /// <summary>
        ///     The DbContextOptions object registered in the service provider must be a DbContextOptions&lt;TContext&gt; where
        ///     TContext is the type of the DbContext being used.
        /// </summary>
        public static string NonGenericOptions
        {
            get { return GetString("NonGenericOptions"); }
        }

        /// <summary>
        ///     The block size used for Hi-Lo value generation must be positive. When the Hi-Lo generator is backed by a SQL
        ///     sequence this means that the sequence increment must be positive.
        /// </summary>
        public static string HiLoBadBlockSize
        {
            get { return GetString("HiLoBadBlockSize"); }
        }

        /// <summary>
        ///     Data binding directly to a store query is not supported. Instead materialize the results into a collection, by
        ///     calling a method such as ToList() or ToArray(), and bind to the collection. This should be done to avoid sending a
        ///     query to the database each time the databound control iterates the data.
        /// </summary>
        public static string DataBindingWithIListSource
        {
            get { return GetString("DataBindingWithIListSource"); }
        }

        /// <summary>
        ///     Unhandled operation: MemberInitExpression binding is not a MemberAssignment
        /// </summary>
        public static string InvalidMemberInitBinding
        {
            get { return GetString("InvalidMemberInitBinding"); }
        }

        /// <summary>
        ///     Sensitive data logging is enabled. Log entries and exception messages may include sensitive application data, this
        ///     mode should only be enabled during development.
        /// </summary>
        public static string SensitiveDataLoggingEnabled
        {
            get { return GetString("SensitiveDataLoggingEnabled"); }
        }

        // <summary>
        // A second operation started on this context before a previous operation completed. Any instance members are not guaranteed to be thread safe.
        // </summary>
        public static string ConcurrentMethodInvocation
        {
            get { return GetString("ConcurrentMethodInvocation"); }
        }

        /// <summary>
        ///     The string argument '{argumentName}' cannot be empty.
        /// </summary>
        public static string ArgumentIsEmpty([CanBeNull] object argumentName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ArgumentIsEmpty", "argumentName"), argumentName);
        }

        /// <summary>
        ///     Unable to save changes because a circular dependency was detected in the data to be saved: '{cycle}'.
        /// </summary>
        public static string CircularDependency([CanBeNull] object cycle)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("CircularDependency", "cycle"), cycle);
        }

        /// <summary>
        ///     The value provided for argument '{argumentName}' must be a valid value of enum type '{enumType}'.
        /// </summary>
        public static string InvalidEnumValue([CanBeNull] object argumentName, [CanBeNull] object enumType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("InvalidEnumValue", "argumentName", "enumType"),
                argumentName, enumType);
        }

        /// <summary>
        ///     The properties expression '{expression}' is not valid. The expression should represent a property access: 't =&gt;
        ///     t.MyProperty'. When specifying multiple properties use an anonymous type: 't =&gt; new {{ t.MyProperty1,
        ///     t.MyProperty2 }}'.
        /// </summary>
        public static string InvalidPropertiesExpression([CanBeNull] object expression)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("InvalidPropertiesExpression", "expression"),
                expression);
        }

        /// <summary>
        ///     The expression '{expression}' is not a valid property expression. The expression should represent a property
        ///     access: 't =&gt; t.MyProperty'.
        /// </summary>
        public static string InvalidPropertyExpression([CanBeNull] object expression)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("InvalidPropertyExpression", "expression"),
                expression);
        }

        /// <summary>
        ///     The instance of entity type '{entityType}' cannot be tracked because another instance of this type with the same
        ///     key is already being tracked. For new entities consider using an IIdentityGenerator to generate unique key values.
        /// </summary>
        public static string IdentityConflict([CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("IdentityConflict", "entityType"), entityType);
        }

        /// <summary>
        ///     Cannot start tracking InternalEntityEntry for entity type '{entityType}' because it was created by a different
        ///     StateManager instance.
        /// </summary>
        public static string WrongStateManager([CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("WrongStateManager", "entityType"), entityType);
        }

        /// <summary>
        ///     Cannot start tracking InternalEntityEntry for entity type '{entityType}' because another InternalEntityEntry is
        ///     already tracking the same entity.
        /// </summary>
        public static string MultipleEntries([CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("MultipleEntries", "entityType"), entityType);
        }

        /// <summary>
        ///     The property '{property}' on entity type '{entityType}' could not be found. Ensure that the property exists and has
        ///     been included in the model.
        /// </summary>
        public static string PropertyNotFound([CanBeNull] object property, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("PropertyNotFound", "property", "entityType"),
                property, entityType);
        }

        /// <summary>
        ///     The collection argument '{argumentName}' must contain at least one element.
        /// </summary>
        public static string CollectionArgumentIsEmpty([CanBeNull] object argumentName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("CollectionArgumentIsEmpty", "argumentName"),
                argumentName);
        }

        /// <summary>
        ///     The entity type '{entityType}' requires a key to be defined.
        /// </summary>
        public static string EntityRequiresKey([CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("EntityRequiresKey", "entityType"), entityType);
        }

        /// <summary>
        ///     The specified key properties {key} are not declared on the entity type '{entityType}'. Ensure key properties are
        ///     declared on the target entity type.
        /// </summary>
        public static string KeyPropertiesWrongEntity([CanBeNull] object key, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("KeyPropertiesWrongEntity", "key", "entityType"),
                key, entityType);
        }

        /// <summary>
        ///     The specified foreign key properties {foreignKey} are not declared on the entity type '{entityType}'. Ensure
        ///     foreign key properties are declared on the target entity type.
        /// </summary>
        public static string ForeignKeyPropertiesWrongEntity([CanBeNull] object foreignKey,
            [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("ForeignKeyPropertiesWrongEntity", "foreignKey", "entityType"), foreignKey, entityType);
        }

        /// <summary>
        ///     The specified index properties {index} are not declared on the entity type '{entityType}'. Ensure index properties
        ///     are declared on the target entity type.
        /// </summary>
        public static string IndexPropertiesWrongEntity([CanBeNull] object index, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("IndexPropertiesWrongEntity", "index", "entityType"), index, entityType);
        }

        /// <summary>
        ///     The source IQueryable doesn't implement IAsyncEnumerable&lt;{genericParameter}&gt;. Only sources that implement
        ///     IAsyncEnumerable can be used for Entity Framework asynchronous operations.
        /// </summary>
        public static string IQueryableNotAsync([CanBeNull] object genericParameter)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("IQueryableNotAsync", "genericParameter"),
                genericParameter);
        }

        /// <summary>
        ///     Lazy original value tracking cannot be turned on for entity type '{entityType}'. Entities that do not implement
        ///     both INotifyPropertyChanging and INotifyPropertyChanged require original values to be stored eagerly in order to
        ///     correct detect changes made to entities.
        /// </summary>
        public static string EagerOriginalValuesRequired([CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("EagerOriginalValuesRequired", "entityType"),
                entityType);
        }

        /// <summary>
        ///     The original value for property '{property}' of entity type '{entityType}' cannot be accessed because it is not
        ///     being tracked. To access all original values set 'UseLazyOriginalValues' to false on the entity type.
        /// </summary>
        public static string OriginalValueNotTracked([CanBeNull] object property, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("OriginalValueNotTracked", "property", "entityType"), property, entityType);
        }

        /// <summary>
        ///     The property '{entityType}.{property}' is annotated with backing field '{field}' but that field cannot be found.
        /// </summary>
        public static string MissingBackingField([CanBeNull] object entityType, [CanBeNull] object property,
            [CanBeNull] object field)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("MissingBackingField", "entityType", "property", "field"), entityType, property, field);
        }

        /// <summary>
        ///     The annotated backing field '{field}' of type '{fieldType}' cannot be used for the property
        ///     '{entityType}.{property}' of type '{propertyType}'. Only backing fields of types that are assignable from the
        ///     property type can be used.
        /// </summary>
        public static string BadBackingFieldType([CanBeNull] object field, [CanBeNull] object fieldType,
            [CanBeNull] object entityType, [CanBeNull] object property, [CanBeNull] object propertyType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("BadBackingFieldType", "field", "fieldType", "entityType", "property", "propertyType"), field,
                fieldType, entityType, property, propertyType);
        }

        /// <summary>
        ///     No backing field could be discovered for property '{entityType}.{property}' and the property does not have a
        ///     setter. Either use a backing field name that can be matched by convention, annotate the property with a backing
        ///     field, or define a property setter.
        /// </summary>
        public static string NoFieldOrSetter([CanBeNull] object entityType, [CanBeNull] object property)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("NoFieldOrSetter", "entityType", "property"),
                entityType, property);
        }

        /// <summary>
        ///     The CLR entity materializer cannot be used for entity type '{entityType}' because it is a shadow-state entity type.
        ///     Materialization to a CLR type is only possible for entity types that have a corresponding CLR type.
        /// </summary>
        public static string NoClrType([CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("NoClrType", "entityType"), entityType);
        }

        /// <summary>
        ///     The database providers {storeNames}are configured. A context can only be configured to use a single database
        ///     provider.
        /// </summary>
        public static string MultipleProvidersConfigured([CanBeNull] object storeNames)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("MultipleProvidersConfigured", "storeNames"),
                storeNames);
        }

        /// <summary>
        ///     The database providers {storeNames}are available. A context can only be configured to use a single database
        ///     provider. Configure a database provider by overriding OnConfiguring in your DbContext class or in the AddDbContext
        ///     method when setting up services.
        /// </summary>
        public static string MultipleProvidersAvailable([CanBeNull] object storeNames)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("MultipleProvidersAvailable", "storeNames"),
                storeNames);
        }

        /// <summary>
        ///     The '{property}' on entity type '{entityType}' does not have a value set and no value generator is available for
        ///     properties of type '{propertyType}'. Either set a value for the property before adding the entity or configure a
        ///     value generator for properties of type '{propertyType}'.
        /// </summary>
        public static string NoValueGenerator([CanBeNull] object property, [CanBeNull] object entityType,
            [CanBeNull] object propertyType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("NoValueGenerator", "property", "entityType", "propertyType"), property, entityType,
                propertyType);
        }

        /// <summary>
        ///     The property '{property}' on entity type '{entityType}' has a temporary value while attempting to change the
        ///     entity's state to '{state}'. Either set a permanent value explicitly or ensure that the database is configured to
        ///     generate values for this property.
        /// </summary>
        public static string TempValuePersists([CanBeNull] object property, [CanBeNull] object entityType,
            [CanBeNull] object state)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("TempValuePersists", "property", "entityType", "state"), property, entityType, state);
        }

        /// <summary>
        ///     An exception occurred in the database while iterating the results of a query.{newline}{error}
        /// </summary>
        public static string LogExceptionDuringQueryIteration([CanBeNull] object newline, [CanBeNull] object error)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("LogExceptionDuringQueryIteration", "newline", "error"), newline, error);
        }

        /// <summary>
        ///     An exception occurred in the database while saving changes.{newline}{error}
        /// </summary>
        public static string LogExceptionDuringSaveChanges([CanBeNull] object newline, [CanBeNull] object error)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("LogExceptionDuringSaveChanges", "newline", "error"), newline, error);
        }

        /// <summary>
        ///     The property '{property}' cannot be added to the entity type '{entityType}' because a property with the same name
        ///     already exists on entity type '{duplicateEntityType}'.
        /// </summary>
        public static string DuplicateProperty([CanBeNull] object property, [CanBeNull] object entityType,
            [CanBeNull] object duplicateEntityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("DuplicateProperty", "property", "entityType", "duplicateEntityType"), property, entityType,
                duplicateEntityType);
        }

        /// <summary>
        ///     The property '{property}' cannot exist on entity type '{entityType}' because the property is not marked as shadow
        ///     state and no corresponding CLR property exists on the underlying type.
        /// </summary>
        public static string NoClrProperty([CanBeNull] object property, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("NoClrProperty", "property", "entityType"),
                property, entityType);
        }

        /// <summary>
        ///     The property '{property}' cannot exist on entity type '{entityType}' because the property is not marked as shadow
        ///     state and the type of the corresponding CLR property does not match the type specified in the property.
        /// </summary>
        public static string PropertyWrongClrType([CanBeNull] object property, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("PropertyWrongClrType", "property", "entityType"),
                property, entityType);
        }

        /// <summary>
        ///     The property '{property}' cannot exist on entity type '{entityType}' because the entity type is marked as shadow
        ///     state while the property is not. Shadow state entity types can only contain shadow state properties.
        /// </summary>
        public static string ClrPropertyOnShadowEntity([CanBeNull] object property, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("ClrPropertyOnShadowEntity", "property", "entityType"), property, entityType);
        }

        /// <summary>
        ///     The property '{property}' cannot be removed from entity type '{entityType}' because it is being used in an index or
        ///     key. All indexes and keys must be removed or redefined before the property can be removed.
        /// </summary>
        public static string PropertyInUse([CanBeNull] object property, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("PropertyInUse", "property", "entityType"),
                property, entityType);
        }

        /// <summary>
        ///     Cannot remove key {key} from entity type '{entityType}' because it is referenced by a foreign key in entity type
        ///     '{dependentType}'. All foreign keys must be removed or redefined before the referenced key can be removed.
        /// </summary>
        public static string KeyInUse([CanBeNull] object key, [CanBeNull] object entityType,
            [CanBeNull] object dependentType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("KeyInUse", "key", "entityType", "dependentType"),
                key, entityType, dependentType);
        }

        /// <summary>
        ///     The navigation property '{navigation}' cannot be added to the entity type '{entityType}' because a navigation
        ///     property with the same name already exists on entity type '{duplicateEntityType}'.
        /// </summary>
        public static string DuplicateNavigation([CanBeNull] object navigation, [CanBeNull] object entityType,
            [CanBeNull] object duplicateEntityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("DuplicateNavigation", "navigation", "entityType", "duplicateEntityType"), navigation,
                entityType, duplicateEntityType);
        }

        /// <summary>
        ///     The navigation property '{navigation}' cannot be added to the entity type '{entityType}' because the entity type is
        ///     defined in shadow state and navigations properties cannot be added to shadow state.
        /// </summary>
        public static string NavigationOnShadowEntity([CanBeNull] object navigation, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("NavigationOnShadowEntity", "navigation", "entityType"), navigation, entityType);
        }

        /// <summary>
        ///     The navigation property '{navigation}' cannot be added to the entity type '{entityType}' because there is no
        ///     corresponding CLR property on the underlying type and navigations properties cannot be added to shadow state.
        /// </summary>
        public static string NoClrNavigation([CanBeNull] object navigation, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("NoClrNavigation", "navigation", "entityType"),
                navigation, entityType);
        }

        /// <summary>
        ///     The navigation property '{navigation}' cannot be added to the entity type '{entityType}' because its CLR type
        ///     '{clrType}' does not match the expected CLR type '{targetType}'.
        /// </summary>
        public static string NavigationSingleWrongClrType([CanBeNull] object navigation, [CanBeNull] object entityType,
            [CanBeNull] object clrType, [CanBeNull] object targetType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("NavigationSingleWrongClrType", "navigation", "entityType", "clrType", "targetType"),
                navigation, entityType, clrType, targetType);
        }

        /// <summary>
        ///     The collection navigation property '{navigation}' cannot be added to the entity type '{entityType}' because its CLR
        ///     type '{clrType}' does not implement 'IEnumerable&lt;{targetType}&gt;'. Collection navigation properties must
        ///     implement IEnumerable&lt;&gt; of the related entity.
        /// </summary>
        public static string NavigationCollectionWrongClrType([CanBeNull] object navigation,
            [CanBeNull] object entityType, [CanBeNull] object clrType, [CanBeNull] object targetType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("NavigationCollectionWrongClrType", "navigation", "entityType", "clrType", "targetType"),
                navigation, entityType, clrType, targetType);
        }

        /// <summary>
        ///     The number of properties specified for the foreign key {foreignKey} on entity type '{dependentType}' does not match
        ///     the number of properties in the principal key {principalKey} on entity type '{principalType}'.
        /// </summary>
        public static string ForeignKeyCountMismatch([CanBeNull] object foreignKey, [CanBeNull] object dependentType,
            [CanBeNull] object principalKey, [CanBeNull] object principalType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("ForeignKeyCountMismatch", "foreignKey", "dependentType", "principalKey", "principalType"),
                foreignKey, dependentType, principalKey, principalType);
        }

        /// <summary>
        ///     The types of the properties specified for the foreign key {foreignKey} on entity type '{dependentType}' do not
        ///     match the types of the properties in the principal key {principalKey} on entity type '{principalType}'.
        /// </summary>
        public static string ForeignKeyTypeMismatch([CanBeNull] object foreignKey, [CanBeNull] object dependentType,
            [CanBeNull] object principalKey, [CanBeNull] object principalType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("ForeignKeyTypeMismatch", "foreignKey", "dependentType", "principalKey", "principalType"),
                foreignKey, dependentType, principalKey, principalType);
        }

        /// <summary>
        ///     The type of navigation property '{navigation}' on the entity type '{entityType}' is '{foundType}' which does not
        ///     implement ICollection&lt;{targetType}&gt;. Collection navigation properties must implement ICollection&lt;&gt; of
        ///     the target type.
        /// </summary>
        public static string NavigationBadType([CanBeNull] object navigation, [CanBeNull] object entityType,
            [CanBeNull] object foundType, [CanBeNull] object targetType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("NavigationBadType", "navigation", "entityType", "foundType", "targetType"), navigation,
                entityType, foundType, targetType);
        }

        /// <summary>
        ///     The type of navigation property '{navigation}' on the entity type '{entityType}' is '{foundType}' which is an array
        ///     type.. Collection navigation properties cannot be arrays.
        /// </summary>
        public static string NavigationArray([CanBeNull] object navigation, [CanBeNull] object entityType,
            [CanBeNull] object foundType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("NavigationArray", "navigation", "entityType", "foundType"), navigation, entityType, foundType);
        }

        /// <summary>
        ///     The navigation property '{navigation}' on the entity type '{entityType}' does not have a getter.
        /// </summary>
        public static string NavigationNoGetter([CanBeNull] object navigation, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("NavigationNoGetter", "navigation", "entityType"),
                navigation, entityType);
        }

        /// <summary>
        ///     The navigation property '{navigation}' on the entity type '{entityType}' does not have a setter. Read-only
        ///     collection navigation properties must be initialized before use.
        /// </summary>
        public static string NavigationNoSetter([CanBeNull] object navigation, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("NavigationNoSetter", "navigation", "entityType"),
                navigation, entityType);
        }

        /// <summary>
        ///     The type of navigation property '{navigation}' on the entity type '{entityType}' is '{foundType}' for which it was
        ///     not possible to create a concrete instance. Either initialize the property before use, add a public parameterless
        ///     constructor to the type, or use a type which can be assigned a HashSet&lt;&gt; or List&lt;&gt;.
        /// </summary>
        public static string NavigationCannotCreateType([CanBeNull] object navigation, [CanBeNull] object entityType,
            [CanBeNull] object foundType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("NavigationCannotCreateType", "navigation", "entityType", "foundType"), navigation, entityType,
                foundType);
        }

        /// <summary>
        ///     The property '{property}' on entity type '{entityType}' is part of a key and so cannot be modified or marked as
        ///     modified.
        /// </summary>
        public static string KeyReadOnly([CanBeNull] object property, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("KeyReadOnly", "property", "entityType"),
                property, entityType);
        }

        /// <summary>
        ///     The property '{property}' on entity type '{entityType}' is defined to be read-only after it has been saved, but its
        ///     value has been modified or marked as modified.
        /// </summary>
        public static string PropertyReadOnlyAfterSave([CanBeNull] object property, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("PropertyReadOnlyAfterSave", "property", "entityType"), property, entityType);
        }

        /// <summary>
        ///     The property '{property}' on entity type '{entityType}' is defined to be read-only before it is saved, but its
        ///     value has been set to something other than a temporary or default value.
        /// </summary>
        public static string PropertyReadOnlyBeforeSave([CanBeNull] object property, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("PropertyReadOnlyBeforeSave", "property", "entityType"), property, entityType);
        }

        /// <summary>
        ///     The property '{property}' on entity type '{entityType}' must be marked as read-only after it has been saved because
        ///     it is part of a key. Key properties are always read-only once an entity has been saved for the first time.
        /// </summary>
        public static string KeyPropertyMustBeReadOnly([CanBeNull] object property, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("KeyPropertyMustBeReadOnly", "property", "entityType"), property, entityType);
        }

        /// <summary>
        ///     The association between entity types '{firstType}' and '{secondType}' has been severed but the foreign key for this
        ///     relationship cannot be set to null. If the dependent entity should be deleted, then setup the relationship to use
        ///     cascade deletes.
        /// </summary>
        public static string RelationshipConceptualNull([CanBeNull] object firstType, [CanBeNull] object secondType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("RelationshipConceptualNull", "firstType", "secondType"), firstType, secondType);
        }

        /// <summary>
        ///     The property '{property}' on entity type '{entityType}' is marked as null, but this cannot be saved because the
        ///     property is marked as required.
        /// </summary>
        public static string PropertyConceptualNull([CanBeNull] object property, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("PropertyConceptualNull", "property", "entityType"), property, entityType);
        }

        /// <summary>
        ///     The foreign key {foreignKey} cannot be added to the entity type '{entityType}' because a foreign key on the same
        ///     properties already exists on entity type '{duplicateEntityType}'.
        /// </summary>
        public static string DuplicateForeignKey([CanBeNull] object foreignKey, [CanBeNull] object entityType,
            [CanBeNull] object duplicateEntityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("DuplicateForeignKey", "foreignKey", "entityType", "duplicateEntityType"), foreignKey,
                entityType, duplicateEntityType);
        }

        /// <summary>
        ///     The index {index} cannot be added to the entity type '{entityType}' because an index on the same properties already
        ///     exists on entity type '{duplicateEntityType}'.
        /// </summary>
        public static string DuplicateIndex([CanBeNull] object index, [CanBeNull] object entityType,
            [CanBeNull] object duplicateEntityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("DuplicateIndex", "index", "entityType", "duplicateEntityType"), index, entityType,
                duplicateEntityType);
        }

        /// <summary>
        ///     The key {key} cannot be added to the entity type '{entityType}' because a key on the same properties already exists
        ///     on entity type '{duplicateEntityType}'.
        /// </summary>
        public static string DuplicateKey([CanBeNull] object key, [CanBeNull] object entityType,
            [CanBeNull] object duplicateEntityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("DuplicateKey", "key", "entityType", "duplicateEntityType"), key, entityType,
                duplicateEntityType);
        }

        /// <summary>
        ///     The navigation property '{navigation}' cannot be added to the entity type '{entityType}' because the target entity
        ///     type '{targetType}' is defined in shadow state and navigations properties cannot point to shadow state entities.
        /// </summary>
        public static string NavigationToShadowEntity([CanBeNull] object navigation, [CanBeNull] object entityType,
            [CanBeNull] object targetType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("NavigationToShadowEntity", "navigation", "entityType", "targetType"), navigation, entityType,
                targetType);
        }

        /// <summary>
        ///     The specified entity type '{entityType}' is invalid. It should be either the dependent entity type
        ///     '{dependentType}' or the principal entity type '{principalType}' or an entity type derived from one of them.
        /// </summary>
        public static string EntityTypeNotInRelationship([CanBeNull] object entityType, [CanBeNull] object dependentType,
            [CanBeNull] object principalType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("EntityTypeNotInRelationship", "entityType", "dependentType", "principalType"), entityType,
                dependentType, principalType);
        }

        /// <summary>
        ///     The entity type '{entityType}' cannot be added to the model because an entity with the same name already exists.
        /// </summary>
        public static string DuplicateEntityType([CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("DuplicateEntityType", "entityType"), entityType);
        }

        /// <summary>
        ///     Annotations of type '{type}' are not supported. Only common simple .NET types are currently supported.
        /// </summary>
        public static string UnsupportedAnnotationType([CanBeNull] object type)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("UnsupportedAnnotationType", "type"), type);
        }

        /// <summary>
        ///     The annotation '{annotation}' cannot be added because an annotation with the same name already exists.
        /// </summary>
        public static string DuplicateAnnotation([CanBeNull] object annotation)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("DuplicateAnnotation", "annotation"), annotation);
        }

        /// <summary>
        ///     The annotation '{annotation}' was not found. Ensure that the annotation has been added.
        /// </summary>
        public static string AnnotationNotFound([CanBeNull] object annotation)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("AnnotationNotFound", "annotation"), annotation);
        }

        /// <summary>
        ///     The expression '{expression}' passed to the Include operator could not be bound.
        /// </summary>
        public static string IncludeNonBindableExpression([CanBeNull] object expression)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("IncludeNonBindableExpression", "expression"),
                expression);
        }

        /// <summary>
        ///     Compiling query model: '{queryModel}'
        /// </summary>
        public static string LogCompilingQueryModel([CanBeNull] object queryModel)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("LogCompilingQueryModel", "queryModel"),
                queryModel);
        }

        /// <summary>
        ///     Optimized query model: '{queryModel}'
        /// </summary>
        public static string LogOptimizedQueryModel([CanBeNull] object queryModel)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("LogOptimizedQueryModel", "queryModel"),
                queryModel);
        }

        /// <summary>
        ///     Including navigation: '{navigation}'
        /// </summary>
        public static string LogIncludingNavigation([CanBeNull] object navigation)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("LogIncludingNavigation", "navigation"),
                navigation);
        }

        /// <summary>
        ///     The property '{property}' on entity type '{entityType}' cannot be marked as nullable/optional because the type of
        ///     the property is '{propertyType}' which is not a nullable type. Any property can be marked as non-nullable/required,
        ///     but only properties of nullable types and which are not part of primary key can be marked as nullable/optional.
        /// </summary>
        public static string CannotBeNullable([CanBeNull] object property, [CanBeNull] object entityType,
            [CanBeNull] object propertyType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("CannotBeNullable", "property", "entityType", "propertyType"), property, entityType,
                propertyType);
        }

        /// <summary>
        ///     The entity type '{entityType}' cannot be removed because it is being referenced by foreign key {foreignKey} on
        ///     '{referencingEntityType}'. All referencing foreign keys must be removed or redefined before the entity type can be
        ///     removed.
        /// </summary>
        public static string EntityTypeInUseByForeignKey([CanBeNull] object entityType, [CanBeNull] object foreignKey,
            [CanBeNull] object referencingEntityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("EntityTypeInUseByForeignKey", "entityType", "foreignKey", "referencingEntityType"),
                entityType, foreignKey, referencingEntityType);
        }

        /// <summary>
        ///     The property '{property}' of the argument '{argument}' cannot be null.
        /// </summary>
        public static string ArgumentPropertyNull([CanBeNull] object property, [CanBeNull] object argument)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ArgumentPropertyNull", "property", "argument"),
                property, argument);
        }

        /// <summary>
        ///     The entity type '{type}' provided for the argument '{argumentName}' must be a reference type.
        /// </summary>
        public static string InvalidEntityType([CanBeNull] object type, [CanBeNull] object argumentName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("InvalidEntityType", "type", "argumentName"),
                type, argumentName);
        }

        /// <summary>
        ///     The key {key} on entity type '{entityType}' contains properties in shadow state - {shadowProperties} and it is
        ///     referenced by the foreign key {foreignKey} from entity type '{referencingEntityType}'."
        /// </summary>
        public static string ReferencedShadowKey([CanBeNull] object key, [CanBeNull] object entityType,
            [CanBeNull] object shadowProperties, [CanBeNull] object foreignKey, [CanBeNull] object referencingEntityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("ReferencedShadowKey", "key", "entityType", "shadowProperties", "foreignKey",
                    "referencingEntityType"), key, entityType, shadowProperties, foreignKey, referencingEntityType);
        }

        /// <summary>
        ///     The key {key} on entity type '{entityType}' contains properties in shadow state - {shadowProperties}.
        /// </summary>
        public static string ShadowKey([CanBeNull] object key, [CanBeNull] object entityType,
            [CanBeNull] object shadowProperties)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("ShadowKey", "key", "entityType", "shadowProperties"), key, entityType, shadowProperties);
        }

        /// <summary>
        ///     The '{factory}' cannot create a value generator for property '{property}' on entity type '{entityType}'. Only
        ///     integer properties are supported.
        /// </summary>
        public static string InvalidValueGeneratorFactoryProperty([CanBeNull] object factory,
            [CanBeNull] object property, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("InvalidValueGeneratorFactoryProperty", "factory", "property", "entityType"), factory,
                property, entityType);
        }

        /// <summary>
        ///     The derived type '{derivedType}' cannot have keys other than those declared on the root type '{rootType}'.
        /// </summary>
        public static string DerivedEntityTypeKey([CanBeNull] object derivedType, [CanBeNull] object rootType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("DerivedEntityTypeKey", "derivedType", "rootType"), derivedType, rootType);
        }

        /// <summary>
        ///     The entity type '{entityType}' cannot inherit from '{baseEntityType}' because '{baseEntityType}' is a descendent of
        ///     '{entityType}'.
        /// </summary>
        public static string CircularInheritance([CanBeNull] object entityType, [CanBeNull] object baseEntityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("CircularInheritance", "entityType", "baseEntityType"), entityType, baseEntityType);
        }

        /// <summary>
        ///     Unable to set a base type for entity type '{entityType}' because it has one or more keys defined.
        /// </summary>
        public static string DerivedEntityCannotHaveKeys([CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("DerivedEntityCannotHaveKeys", "entityType"),
                entityType);
        }

        /// <summary>
        ///     The edge cannot be added because the graph does not contain vertex '{vertex}'.
        /// </summary>
        public static string GraphDoesNotContainVertex([CanBeNull] object vertex)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("GraphDoesNotContainVertex", "vertex"), vertex);
        }

        /// <summary>
        ///     Unable to create an instance of type entity type '{entityType}' because it is abstract. Either make it non-abstract
        ///     or consider mapping at least one derived type.
        /// </summary>
        public static string CannotMaterializeAbstractType([CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("CannotMaterializeAbstractType", "entityType"),
                entityType);
        }

        /// <summary>
        ///     The provided principal entity key '{principalKey}' is not a key on the entity type '{principalEntityType}'.
        /// </summary>
        public static string ForeignKeyReferencedEntityKeyMismatch([CanBeNull] object principalKey,
            [CanBeNull] object principalEntityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("ForeignKeyReferencedEntityKeyMismatch", "principalKey", "principalEntityType"), principalKey,
                principalEntityType);
        }

        /// <summary>
        ///     Property '{property}' on entity type '{entityType}' is of type '{actualType}' but the generic type provided is of
        ///     type '{genericType}'.
        /// </summary>
        public static string WrongGenericPropertyType([CanBeNull] object property, [CanBeNull] object entityType,
            [CanBeNull] object actualType, [CanBeNull] object genericType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("WrongGenericPropertyType", "property", "entityType", "actualType", "genericType"), property,
                entityType, actualType, genericType);
        }

        /// <summary>
        ///     Options extension of type '{optionsExtension}' not found.
        /// </summary>
        public static string OptionsExtensionNotFound([CanBeNull] object optionsExtension)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("OptionsExtensionNotFound", "optionsExtension"),
                optionsExtension);
        }

        /// <summary>
        ///     The type '{entityType}' cannot have base type '{baseType}' because both types include the properties: {properties}.
        /// </summary>
        public static string DuplicatePropertiesOnBase([CanBeNull] object entityType, [CanBeNull] object baseType,
            [CanBeNull] object properties)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("DuplicatePropertiesOnBase", "entityType", "baseType", "properties"), entityType, baseType,
                properties);
        }

        /// <summary>
        ///     The property '{property}' on entity type '{entityType}' cannot be marked as nullable/optional because the property
        ///     is a part of a key. Any property can be marked as non-nullable/required, but only properties of nullable types and
        ///     which are not part of a key can be marked as nullable/optional.
        /// </summary>
        public static string CannotBeNullablePK([CanBeNull] object property, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("CannotBeNullablePK", "property", "entityType"),
                property, entityType);
        }

        /// <summary>
        ///     The foreign key {foreignKey} on entity type '{entityType}' cannot be marked as optional because it does not contain
        ///     any property of a nullable type. Any foreign key can be marked as required, but only foreign keys with at least one
        ///     property of a nullable type and which is not part of primary key can be marked as optional.
        /// </summary>
        public static string ForeignKeyCannotBeOptional([CanBeNull] object foreignKey, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("ForeignKeyCannotBeOptional", "foreignKey", "entityType"), foreignKey, entityType);
        }

        /// <summary>
        ///     Entity type '{entityType}' is in shadow-state. A valid model requires all entity types to have corresponding CLR
        ///     type.
        /// </summary>
        public static string ShadowEntity([CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ShadowEntity", "entityType"), entityType);
        }

        /// <summary>
        ///     Entity type '{entityType}' has composite primary key defined with data annotations. To set composite primary key,
        ///     use fluent API.
        /// </summary>
        public static string CompositePKWithDataAnnotation([CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("CompositePKWithDataAnnotation", "entityType"),
                entityType);
        }

        /// <summary>
        ///     The type '{entityType}' cannot have base type '{baseType}' because both types include the navigations:
        ///     {navigations}.
        /// </summary>
        public static string DuplicateNavigationsOnBase([CanBeNull] object entityType, [CanBeNull] object baseType,
            [CanBeNull] object navigations)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("DuplicateNavigationsOnBase", "entityType", "baseType", "navigations"), entityType, baseType,
                navigations);
        }

        /// <summary>
        ///     The entity types '{firstEntityType}' and '{secondEntityType}' do not belong to the same model.
        /// </summary>
        public static string EntityTypeModelMismatch([CanBeNull] object firstEntityType,
            [CanBeNull] object secondEntityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("EntityTypeModelMismatch", "firstEntityType", "secondEntityType"), firstEntityType,
                secondEntityType);
        }

        /// <summary>
        ///     The entity type related to '{entityType}' cannot be determined because the specified foreign key {foreignKey}
        ///     references entity type '{principalEntityType}' that it is in the same hierarchy as the entity type that it is
        ///     declared on '{dependentEntityType}'.
        /// </summary>
        public static string IntraHierarchicalAmbiguousTargetEntityType([CanBeNull] object entityType,
            [CanBeNull] object foreignKey, [CanBeNull] object principalEntityType,
            [CanBeNull] object dependentEntityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("IntraHierarchicalAmbiguousTargetEntityType", "entityType", "foreignKey",
                    "principalEntityType", "dependentEntityType"), entityType, foreignKey, principalEntityType,
                dependentEntityType);
        }

        /// <summary>
        ///     The entity type '{entityType}' cannot inherit from '{baseEntityType}' because '{baseEntityType}' is a shadow state
        ///     entity type while '{entityType}' is not.
        /// </summary>
        public static string NonClrBaseType([CanBeNull] object entityType, [CanBeNull] object baseEntityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("NonClrBaseType", "entityType", "baseEntityType"),
                entityType, baseEntityType);
        }

        /// <summary>
        ///     The entity type '{entityType}' cannot inherit from '{baseEntityType}' because '{entityType}' is a shadow state
        ///     entity type while '{baseEntityType}' is not.
        /// </summary>
        public static string NonShadowBaseType([CanBeNull] object entityType, [CanBeNull] object baseEntityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("NonShadowBaseType", "entityType", "baseEntityType"), entityType, baseEntityType);
        }

        /// <summary>
        ///     The entity type '{entityType}' cannot inherit from '{baseEntityType}' because '{clrType}' is not a descendent of
        ///     '{baseClrType}'.
        /// </summary>
        public static string NotAssignableClrBaseType([CanBeNull] object entityType, [CanBeNull] object baseEntityType,
            [CanBeNull] object clrType, [CanBeNull] object baseClrType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("NotAssignableClrBaseType", "entityType", "baseEntityType", "clrType", "baseClrType"),
                entityType, baseEntityType, clrType, baseClrType);
        }

        /// <summary>
        ///     CLR property '{property}' cannot be added to entity type '{entityType}' because it is declared on the CLR type
        ///     '{clrType}'.
        /// </summary>
        public static string PropertyWrongEntityClrType([CanBeNull] object property, [CanBeNull] object entityType,
            [CanBeNull] object clrType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("PropertyWrongEntityClrType", "property", "entityType", "clrType"), property, entityType,
                clrType);
        }

        /// <summary>
        ///     The CLR type for property '{property}' cannot be changed because it is referenced by the foreign key {foreignKey}
        ///     from entity type '{entityType}'.
        /// </summary>
        public static string PropertyClrTypeCannotBeChangedWhenReferenced([CanBeNull] object property,
            [CanBeNull] object foreignKey, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("PropertyClrTypeCannotBeChangedWhenReferenced", "property", "foreignKey", "entityType"),
                property, foreignKey, entityType);
        }

        /// <summary>
        ///     The InversePropertyAttribute on property '{property}' on type '{entityType}' is not valid. The property
        ///     '{referencedProperty}' is not a valid navigation property on the related type '{referencedEntityType}'. Ensure that
        ///     the property exists and is a valid reference or collection navigation property.
        /// </summary>
        public static string InvalidNavigationWithInverseProperty([CanBeNull] object property,
            [CanBeNull] object entityType, [CanBeNull] object referencedProperty,
            [CanBeNull] object referencedEntityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("InvalidNavigationWithInverseProperty", "property", "entityType", "referencedProperty",
                    "referencedEntityType"), property, entityType, referencedProperty, referencedEntityType);
        }

        /// <summary>
        ///     A relationship cannot be established from property '{property}' on type '{entityType}' to property
        ///     '{referencedProperty}' on type '{referencedEntityType}'. Check the values in the InversePropertyAttribute to ensure
        ///     relationship definitions are unique and reference from one navigation property to its corresponding inverse
        ///     navigation property.
        /// </summary>
        public static string SelfReferencingNavigationWithInverseProperty([CanBeNull] object property,
            [CanBeNull] object entityType, [CanBeNull] object referencedProperty,
            [CanBeNull] object referencedEntityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("SelfReferencingNavigationWithInverseProperty", "property", "entityType", "referencedProperty",
                    "referencedEntityType"), property, entityType, referencedProperty, referencedEntityType);
        }

        /// <summary>
        ///     The derived type '{derivedType}' cannot have KeyAttribute on property '{property}' since primary key can only be
        ///     declared on the root type.
        /// </summary>
        public static string KeyAttributeOnDerivedEntity([CanBeNull] object derivedType, [CanBeNull] object property)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("KeyAttributeOnDerivedEntity", "derivedType", "property"), derivedType, property);
        }

        /// <summary>
        ///     InversePropertyAttributes on navigation '{navigation}' in entity type '{entityType}' and on navigation
        ///     '{referencedNavigation}' in entity type '{referencedEntityType}' are not pointing to each other.
        /// </summary>
        public static string InversePropertyMismatch([CanBeNull] object navigation, [CanBeNull] object entityType,
            [CanBeNull] object referencedNavigation, [CanBeNull] object referencedEntityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("InversePropertyMismatch", "navigation", "entityType", "referencedNavigation",
                    "referencedEntityType"), navigation, entityType, referencedNavigation, referencedEntityType);
        }

        /// <summary>
        ///     There are multiple properties pointing to navigation '{navigation}' in entity type '{entityType}'. To define
        ///     composite foreign key using data annotations, use ForeignKeyAttribute on navigation.
        /// </summary>
        public static string CompositeFkOnProperty([CanBeNull] object navigation, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("CompositeFkOnProperty", "navigation", "entityType"), navigation, entityType);
        }

        /// <summary>
        ///     The ForeignKeyAttributes on property '{property}' and navigation '{navigation}' in entity type '{entityType}' do
        ///     not point at each other. The value of ForeignKeyAttribute on property should be navigation name and the value of
        ///     ForeignKeyAttribute on navigation should be the foreign key property name.
        /// </summary>
        public static string FkAttributeOnPropertyNavigationMismatch([CanBeNull] object property,
            [CanBeNull] object navigation, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("FkAttributeOnPropertyNavigationMismatch", "property", "navigation", "entityType"), property,
                navigation, entityType);
        }

        /// <summary>
        ///     The property list specified using ForeignKeyAttribute on navigation '{navigation}' in entity type '{entityType}' is
        ///     incorrect. The attribute value should be comma-separated list of property names.
        /// </summary>
        public static string InvalidPropertyListOnNavigation([CanBeNull] object navigation,
            [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("InvalidPropertyListOnNavigation", "navigation", "entityType"), navigation, entityType);
        }

        /// <summary>
        ///     Invalid relationship has been specified using InverseProperty and ForeignKey. The navigation '{navigation}' in
        ///     entity type '{entityType}' and the navigation '{referencedNavigation}' in entity type '{referencedEntityType}' are
        ///     related by InversePropertyAttribute but the ForeignKeyAttribute specified for both navigations have different
        ///     values.
        /// </summary>
        public static string InvalidRelationshipUsingDataAnnotations([CanBeNull] object navigation,
            [CanBeNull] object entityType, [CanBeNull] object referencedNavigation,
            [CanBeNull] object referencedEntityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("InvalidRelationshipUsingDataAnnotations", "navigation", "entityType", "referencedNavigation",
                    "referencedEntityType"), navigation, entityType, referencedNavigation, referencedEntityType);
        }

        /// <summary>
        ///     The property '{property}' cannot be added to the entity type '{entityType}' because a navigation property with the
        ///     same name already exists on entity type '{duplicateEntityType}'.
        /// </summary>
        public static string ConflictingNavigation([CanBeNull] object property, [CanBeNull] object entityType,
            [CanBeNull] object duplicateEntityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("ConflictingNavigation", "property", "entityType", "duplicateEntityType"), property,
                entityType, duplicateEntityType);
        }

        /// <summary>
        ///     The navigation property '{navigation}' cannot be added to the entity type '{entityType}' because a property with
        ///     the same name already exists on entity type '{duplicateEntityType}'.
        /// </summary>
        public static string ConflictingProperty([CanBeNull] object navigation, [CanBeNull] object entityType,
            [CanBeNull] object duplicateEntityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("ConflictingProperty", "navigation", "entityType", "duplicateEntityType"), navigation,
                entityType, duplicateEntityType);
        }

        /// <summary>
        ///     The specified entity type '{entityType}' is invalid. It should be either the dependent entity type
        ///     '{dependentType}' or the principal entity type '{principalType}'.
        /// </summary>
        public static string EntityTypeNotInRelationshipStrict([CanBeNull] object entityType,
            [CanBeNull] object dependentType, [CanBeNull] object principalType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("EntityTypeNotInRelationshipStrict", "entityType", "dependentType", "principalType"),
                entityType, dependentType, principalType);
        }

        /// <summary>
        ///     The entity type '{entityType}' cannot be removed because '{derivedEntityType}' is derived from it. All derived
        ///     entity types must be removed or redefined before the entity type can be removed.
        /// </summary>
        public static string EntityTypeInUseByDerived([CanBeNull] object entityType,
            [CanBeNull] object derivedEntityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("EntityTypeInUseByDerived", "entityType", "derivedEntityType"), entityType, derivedEntityType);
        }

        /// <summary>
        ///     The navigation '{navigation}' on entity type '{entityType}' has not been added to the model, or ignored, or target
        ///     entityType ignored.
        /// </summary>
        public static string NavigationNotAdded([CanBeNull] object navigation, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("NavigationNotAdded", "navigation", "entityType"),
                navigation, entityType);
        }

        /// <summary>
        ///     The property '{property}' on entity type '{entityType}' has not been added to the model or ignored.
        /// </summary>
        public static string PropertyNotAdded([CanBeNull] object property, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("PropertyNotAdded", "property", "entityType"),
                property, entityType);
        }

        /// <summary>
        ///     The property '{property}' on entity type '{entityType}' has CLR type which is not supported by current provider and
        ///     it has not been configured to use any supported column type.
        /// </summary>
        public static string PropertyNotMapped([CanBeNull] object property, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("PropertyNotMapped", "property", "entityType"),
                property, entityType);
        }

        /// <summary>
        ///     The navigation property '{navigation}' on entity type '{entityType}' cannot be associated with foreign key
        ///     {targetFk} because it was created for foreign key {actualFk}.
        /// </summary>
        public static string NavigationForWrongForeignKey([CanBeNull] object navigation, [CanBeNull] object entityType,
            [CanBeNull] object targetFk, [CanBeNull] object actualFk)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("NavigationForWrongForeignKey", "navigation", "entityType", "targetFk", "actualFk"),
                navigation, entityType, targetFk, actualFk);
        }

        /// <summary>
        ///     The specified CLR type '{clrType}' does not match the entity type name '{entity}'.
        /// </summary>
        public static string ClrTypeWrongName([CanBeNull] object clrType, [CanBeNull] object entity)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ClrTypeWrongName", "clrType", "entity"), clrType,
                entity);
        }

        /// <summary>
        ///     The CLR type cannot be set on the entity type '{entityType}' because it has members, base entity type or derived
        ///     entity types.
        /// </summary>
        public static string EntityTypeInUse([CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("EntityTypeInUse", "entityType"), entityType);
        }

        /// <summary>
        ///     The entity type '{entityType}' was not found. Ensure that the entity type has been added to the model.
        /// </summary>
        public static string EntityTypeNotFound([CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("EntityTypeNotFound", "entityType"), entityType);
        }

        /// <summary>
        ///     Unhandled expression type: {expressionType}
        /// </summary>
        public static string UnhandledExpressionType([CanBeNull] object expressionType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("UnhandledExpressionType", "expressionType"),
                expressionType);
        }

        /// <summary>
        ///     Unhandled node type: {nodeType}
        /// </summary>
        public static string UnhandledNodeType([CanBeNull] object nodeType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("UnhandledNodeType", "nodeType"), nodeType);
        }

        /// <summary>
        ///     Unable to create or track an entity of type '{entityType}' because it has an null primary or alternate key value.
        /// </summary>
        public static string InvalidKeyValue([CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("InvalidKeyValue", "entityType"), entityType);
        }

        /// <summary>
        ///     An exception was thrown while attempting to evaluate the LINQ query parameter expression '{expression}'.
        /// </summary>
        public static string ExpressionParameterizationExceptionSensitive([CanBeNull] object expression)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("ExpressionParameterizationExceptionSensitive", "expression"), expression);
        }

        /// <summary>
        ///     There are multiple navigations in entity type '{entityType}' which are pointing to same set of properties -
        ///     '{propertyList}' using ForeignKeyAttribute.
        /// </summary>
        public static string MultipleNavigationsSameFk([CanBeNull] object entityType, [CanBeNull] object propertyList)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("MultipleNavigationsSameFk", "entityType", "propertyList"), entityType, propertyList);
        }

        /// <summary>
        ///     The entity type '{entityType}' should derive from '{baseEntityType}' to reflect the hierarchy of the corresponding
        ///     CLR types.
        /// </summary>
        public static string InconsistentInheritance([CanBeNull] object entityType, [CanBeNull] object baseEntityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("InconsistentInheritance", "entityType", "baseEntityType"), entityType, baseEntityType);
        }

        /// <summary>
        ///     You are configuring a relationship between '{dependentEntityType}' and '{principalEntityType}' but have specified a
        ///     foreign key on '{entityType}'. The foreign key must be defined on a type that is part of the relationship.
        /// </summary>
        public static string DependentEntityTypeNotInRelationship([CanBeNull] object dependentEntityType,
            [CanBeNull] object principalEntityType, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("DependentEntityTypeNotInRelationship", "dependentEntityType", "principalEntityType",
                    "entityType"), dependentEntityType, principalEntityType, entityType);
        }

        /// <summary>
        ///     You are configuring a relationship between '{dependentEntityType}' and '{principalEntityType}' but have specified a
        ///     foreign key targetting '{entityType}'. The foreign key must be targetting a type that is part of the relationship.
        /// </summary>
        public static string PrincipalEntityTypeNotInRelationship([CanBeNull] object dependentEntityType,
            [CanBeNull] object principalEntityType, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("PrincipalEntityTypeNotInRelationship", "dependentEntityType", "principalEntityType",
                    "entityType"), dependentEntityType, principalEntityType, entityType);
        }

        /// <summary>
        ///     The property '{property}' cannot be part of a foreign key on '{entityType}' because it is contained in a key
        ///     defined on a base entity type.
        /// </summary>
        public static string ForeignKeyPropertyInKey([CanBeNull] object property, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("ForeignKeyPropertyInKey", "property", "entityType"), property, entityType);
        }

        /// <summary>
        ///     The property '{property}' cannot be part of a key on '{entityType}' because it is contained in a foreign key
        ///     defined on a derived entity type.
        /// </summary>
        public static string KeyPropertyInForeignKey([CanBeNull] object property, [CanBeNull] object entityType)
        {
            return string.Format(CultureInfo.CurrentCulture,
                GetString("KeyPropertyInForeignKey", "property", "entityType"), property, entityType);
        }

        /// <summary>
        ///     A key on entity type '{entityType}' cannot contain the property '{property}' because it is nullable/optional. All
        ///     properties on which a key is declared must be marked as non-nullable/required.
        /// </summary>
        public static string NullableKey([CanBeNull] object entityType, [CanBeNull] object property)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("NullableKey", "entityType", "property"),
                entityType, property);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}