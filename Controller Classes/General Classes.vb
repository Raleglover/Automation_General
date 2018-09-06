''' <summary>
''' One or more controllers that were purchased at one time. The Job Number assigned is
''' in the format of YYMMDD-### where ### is a incremental number to differentiate jobs created on the same day.
''' 181207-003= the third job created on the 7th of december 2018
''' </summary>
Public Class Job
    Public UIN As Integer = 0                               'Unique Identification Number
    Public JonNumber As String = ""                         'job number
    Public GroupList_AL As New ArrayList                    'list of groups in the Job
End Class
''' <summary>
''' A collection of one or more cars. A group of cars work together to service a common set of floors
''' </summary>
Public Class Group
    Public GroupID As Integer = 0                           '1 - x
    Public GroupName As String = ""                         'group names can be provided for clarity (WEST BANK)
    Public CarList_AL As New ArrayList                      'list of cars in the group
End Class

''' <summary>
''' A single elevator car
''' </summary>
Public Class Car
    Public CarID As Integer = 0                             '1 - x
End Class
Public Enum eMachineType
    NONE = 0
    HYDRAULIC = 1
    GEARED = 2
    GEARLESS = 3
End Enum
Public Enum eControllerType
    UNKNOWN = 0                                             'not assigned
    V2 = 1                                                  'version 2
    V3 = 2                                                  'version 3 (Canada)
    C4 = 3                                                  'C4 
    DEV1 = 4                                                'Developement 1
    DEV2 = 5                                                'Developement 2
    DEV3 = 6                                                'Developement 3
    DEV4 = 7                                                'Developement 4
End Enum

''' <summary>
''' Describes the physical elements of the car
''' </summary>
Public Class Physical_Car
    Public Contract_Speed As Integer = 0                    'FPM (feet per minute)
    Public Capacity As Integer = 0                          'lbs
    Public NumDoors As Integer = 0                          '# of car doors
    Public NumHallButtonRisers As Integer = 0               'typically 0, but could be 1
End Class
Public Class Physical_Hoistway
    Public NumLandings As Integer = 0                       '# of landings (include ALL landings with magnets)
    Public PitHeight As Double = 0                          'height of pit (in feet)
    Public OverheadHeight As Double = 0                     'height of overhead (in feet)
    Public Landingheight_AL(cMAX_LANDINGS) As Double        'heigh of each landing (set top landing = 0)
End Class
''' <summary>        
''' Describes the physical elements of the group
''' </summary>
Public Class Physical_Group
    Public NumberOfCars As Integer = 0                      'how many cars in the group
    Public NumberOfHallButtonRisers As Integer = 0
End Class
Public Class Physical_SmartriseController
    Public Type As eControllerType = eControllerType.UNKNOWN 'type of controller
    Public MRControllerBoards_AL As New ArrayList()         'Machine room control boards
    Public CTControllerBoards_AL As New ArrayList()         'Car-Top control boards
    Public COPControllerBoards_AL As New ArrayList()        'Car Operating Panel control boards
End Class
