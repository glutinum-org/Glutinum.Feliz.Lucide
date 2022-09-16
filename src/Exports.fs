namespace Feliz.Lucide

open Feliz
open Fable.Core
open Fable.Core.JsInterop

[<Erase>]
type Lucide =

    static member inline Accessibility (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Accessibility" "lucide-react", createObj !!properties)

    static member inline Activity (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Activity" "lucide-react", createObj !!properties)

    static member inline AirVent (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AirVent" "lucide-react", createObj !!properties)

    static member inline Airplay (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Airplay" "lucide-react", createObj !!properties)

    static member inline AlarmCheck (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlarmCheck" "lucide-react", createObj !!properties)

    static member inline AlarmClockOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlarmClockOff" "lucide-react", createObj !!properties)

    static member inline AlarmClock (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlarmClock" "lucide-react", createObj !!properties)

    static member inline AlarmMinus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlarmMinus" "lucide-react", createObj !!properties)

    static member inline AlarmPlus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlarmPlus" "lucide-react", createObj !!properties)

    static member inline Album (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Album" "lucide-react", createObj !!properties)

    static member inline AlertCircle (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlertCircle" "lucide-react", createObj !!properties)

    static member inline AlertOctagon (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlertOctagon" "lucide-react", createObj !!properties)

    static member inline AlertTriangle (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlertTriangle" "lucide-react", createObj !!properties)

    static member inline AlignCenterHorizontal (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlignCenterHorizontal" "lucide-react", createObj !!properties)

    static member inline AlignCenterVertical (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlignCenterVertical" "lucide-react", createObj !!properties)

    static member inline AlignCenter (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlignCenter" "lucide-react", createObj !!properties)

    static member inline AlignEndHorizontal (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlignEndHorizontal" "lucide-react", createObj !!properties)

    static member inline AlignEndVertical (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlignEndVertical" "lucide-react", createObj !!properties)

    static member inline AlignHorizontalDistributeCenter (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlignHorizontalDistributeCenter" "lucide-react", createObj !!properties)

    static member inline AlignHorizontalDistributeEnd (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlignHorizontalDistributeEnd" "lucide-react", createObj !!properties)

    static member inline AlignHorizontalDistributeStart (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlignHorizontalDistributeStart" "lucide-react", createObj !!properties)

    static member inline AlignHorizontalJustifyCenter (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlignHorizontalJustifyCenter" "lucide-react", createObj !!properties)

    static member inline AlignHorizontalJustifyEnd (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlignHorizontalJustifyEnd" "lucide-react", createObj !!properties)

    static member inline AlignHorizontalJustifyStart (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlignHorizontalJustifyStart" "lucide-react", createObj !!properties)

    static member inline AlignHorizontalSpaceAround (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlignHorizontalSpaceAround" "lucide-react", createObj !!properties)

    static member inline AlignHorizontalSpaceBetween (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlignHorizontalSpaceBetween" "lucide-react", createObj !!properties)

    static member inline AlignJustify (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlignJustify" "lucide-react", createObj !!properties)

    static member inline AlignLeft (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlignLeft" "lucide-react", createObj !!properties)

    static member inline AlignRight (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlignRight" "lucide-react", createObj !!properties)

    static member inline AlignStartHorizontal (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlignStartHorizontal" "lucide-react", createObj !!properties)

    static member inline AlignStartVertical (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlignStartVertical" "lucide-react", createObj !!properties)

    static member inline AlignVerticalDistributeCenter (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlignVerticalDistributeCenter" "lucide-react", createObj !!properties)

    static member inline AlignVerticalDistributeEnd (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlignVerticalDistributeEnd" "lucide-react", createObj !!properties)

    static member inline AlignVerticalDistributeStart (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlignVerticalDistributeStart" "lucide-react", createObj !!properties)

    static member inline AlignVerticalJustifyCenter (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlignVerticalJustifyCenter" "lucide-react", createObj !!properties)

    static member inline AlignVerticalJustifyEnd (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlignVerticalJustifyEnd" "lucide-react", createObj !!properties)

    static member inline AlignVerticalJustifyStart (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlignVerticalJustifyStart" "lucide-react", createObj !!properties)

    static member inline AlignVerticalSpaceAround (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlignVerticalSpaceAround" "lucide-react", createObj !!properties)

    static member inline AlignVerticalSpaceBetween (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AlignVerticalSpaceBetween" "lucide-react", createObj !!properties)

    static member inline Anchor (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Anchor" "lucide-react", createObj !!properties)

    static member inline Angry (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Angry" "lucide-react", createObj !!properties)

    static member inline Annoyed (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Annoyed" "lucide-react", createObj !!properties)

    static member inline Aperture (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Aperture" "lucide-react", createObj !!properties)

    static member inline Apple (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Apple" "lucide-react", createObj !!properties)

    static member inline ArchiveRestore (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ArchiveRestore" "lucide-react", createObj !!properties)

    static member inline Archive (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Archive" "lucide-react", createObj !!properties)

    static member inline Armchair (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Armchair" "lucide-react", createObj !!properties)

    static member inline ArrowBigDown (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ArrowBigDown" "lucide-react", createObj !!properties)

    static member inline ArrowBigLeft (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ArrowBigLeft" "lucide-react", createObj !!properties)

    static member inline ArrowBigRight (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ArrowBigRight" "lucide-react", createObj !!properties)

    static member inline ArrowBigUp (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ArrowBigUp" "lucide-react", createObj !!properties)

    static member inline ArrowDownCircle (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ArrowDownCircle" "lucide-react", createObj !!properties)

    static member inline ArrowDownLeft (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ArrowDownLeft" "lucide-react", createObj !!properties)

    static member inline ArrowDownRight (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ArrowDownRight" "lucide-react", createObj !!properties)

    static member inline ArrowDown (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ArrowDown" "lucide-react", createObj !!properties)

    static member inline ArrowLeftCircle (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ArrowLeftCircle" "lucide-react", createObj !!properties)

    static member inline ArrowLeftRight (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ArrowLeftRight" "lucide-react", createObj !!properties)

    static member inline ArrowLeft (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ArrowLeft" "lucide-react", createObj !!properties)

    static member inline ArrowRightCircle (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ArrowRightCircle" "lucide-react", createObj !!properties)

    static member inline ArrowRight (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ArrowRight" "lucide-react", createObj !!properties)

    static member inline ArrowUpCircle (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ArrowUpCircle" "lucide-react", createObj !!properties)

    static member inline ArrowUpDown (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ArrowUpDown" "lucide-react", createObj !!properties)

    static member inline ArrowUpLeft (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ArrowUpLeft" "lucide-react", createObj !!properties)

    static member inline ArrowUpRight (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ArrowUpRight" "lucide-react", createObj !!properties)

    static member inline ArrowUp (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ArrowUp" "lucide-react", createObj !!properties)

    static member inline Asterisk (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Asterisk" "lucide-react", createObj !!properties)

    static member inline AtSign (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "AtSign" "lucide-react", createObj !!properties)

    static member inline Award (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Award" "lucide-react", createObj !!properties)

    static member inline Axe (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Axe" "lucide-react", createObj !!properties)

    static member inline Axis3d (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Axis3d" "lucide-react", createObj !!properties)

    static member inline Baby (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Baby" "lucide-react", createObj !!properties)

    static member inline Backpack (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Backpack" "lucide-react", createObj !!properties)

    static member inline BaggageClaim (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "BaggageClaim" "lucide-react", createObj !!properties)

    static member inline Banana (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Banana" "lucide-react", createObj !!properties)

    static member inline Banknote (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Banknote" "lucide-react", createObj !!properties)

    static member inline BarChart2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "BarChart2" "lucide-react", createObj !!properties)

    static member inline BarChart3 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "BarChart3" "lucide-react", createObj !!properties)

    static member inline BarChart4 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "BarChart4" "lucide-react", createObj !!properties)

    static member inline BarChartHorizontal (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "BarChartHorizontal" "lucide-react", createObj !!properties)

    static member inline BarChart (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "BarChart" "lucide-react", createObj !!properties)

    static member inline Baseline (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Baseline" "lucide-react", createObj !!properties)

    static member inline Bath (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Bath" "lucide-react", createObj !!properties)

    static member inline BatteryCharging (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "BatteryCharging" "lucide-react", createObj !!properties)

    static member inline BatteryFull (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "BatteryFull" "lucide-react", createObj !!properties)

    static member inline BatteryLow (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "BatteryLow" "lucide-react", createObj !!properties)

    static member inline BatteryMedium (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "BatteryMedium" "lucide-react", createObj !!properties)

    static member inline Battery (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Battery" "lucide-react", createObj !!properties)

    static member inline Beaker (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Beaker" "lucide-react", createObj !!properties)

    static member inline BedDouble (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "BedDouble" "lucide-react", createObj !!properties)

    static member inline BedSingle (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "BedSingle" "lucide-react", createObj !!properties)

    static member inline Bed (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Bed" "lucide-react", createObj !!properties)

    static member inline Beer (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Beer" "lucide-react", createObj !!properties)

    static member inline BellMinus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "BellMinus" "lucide-react", createObj !!properties)

    static member inline BellOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "BellOff" "lucide-react", createObj !!properties)

    static member inline BellPlus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "BellPlus" "lucide-react", createObj !!properties)

    static member inline BellRing (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "BellRing" "lucide-react", createObj !!properties)

    static member inline Bell (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Bell" "lucide-react", createObj !!properties)

    static member inline Bike (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Bike" "lucide-react", createObj !!properties)

    static member inline Binary (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Binary" "lucide-react", createObj !!properties)

    static member inline Bitcoin (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Bitcoin" "lucide-react", createObj !!properties)

    static member inline BluetoothConnected (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "BluetoothConnected" "lucide-react", createObj !!properties)

    static member inline BluetoothOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "BluetoothOff" "lucide-react", createObj !!properties)

    static member inline BluetoothSearching (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "BluetoothSearching" "lucide-react", createObj !!properties)

    static member inline Bluetooth (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Bluetooth" "lucide-react", createObj !!properties)

    static member inline Bold (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Bold" "lucide-react", createObj !!properties)

    static member inline Bomb (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Bomb" "lucide-react", createObj !!properties)

    static member inline Bone (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Bone" "lucide-react", createObj !!properties)

    static member inline BookOpen (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "BookOpen" "lucide-react", createObj !!properties)

    static member inline Book (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Book" "lucide-react", createObj !!properties)

    static member inline BookmarkMinus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "BookmarkMinus" "lucide-react", createObj !!properties)

    static member inline BookmarkPlus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "BookmarkPlus" "lucide-react", createObj !!properties)

    static member inline Bookmark (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Bookmark" "lucide-react", createObj !!properties)

    static member inline Bot (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Bot" "lucide-react", createObj !!properties)

    static member inline BoxSelect (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "BoxSelect" "lucide-react", createObj !!properties)

    static member inline Box (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Box" "lucide-react", createObj !!properties)

    static member inline Boxes (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Boxes" "lucide-react", createObj !!properties)

    static member inline Briefcase (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Briefcase" "lucide-react", createObj !!properties)

    static member inline Brush (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Brush" "lucide-react", createObj !!properties)

    static member inline Bug (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Bug" "lucide-react", createObj !!properties)

    static member inline Building2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Building2" "lucide-react", createObj !!properties)

    static member inline Building (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Building" "lucide-react", createObj !!properties)

    static member inline Bus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Bus" "lucide-react", createObj !!properties)

    static member inline Cake (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Cake" "lucide-react", createObj !!properties)

    static member inline Calculator (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Calculator" "lucide-react", createObj !!properties)

    static member inline CalendarCheck2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CalendarCheck2" "lucide-react", createObj !!properties)

    static member inline CalendarCheck (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CalendarCheck" "lucide-react", createObj !!properties)

    static member inline CalendarClock (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CalendarClock" "lucide-react", createObj !!properties)

    static member inline CalendarDays (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CalendarDays" "lucide-react", createObj !!properties)

    static member inline CalendarHeart (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CalendarHeart" "lucide-react", createObj !!properties)

    static member inline CalendarMinus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CalendarMinus" "lucide-react", createObj !!properties)

    static member inline CalendarOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CalendarOff" "lucide-react", createObj !!properties)

    static member inline CalendarPlus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CalendarPlus" "lucide-react", createObj !!properties)

    static member inline CalendarRange (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CalendarRange" "lucide-react", createObj !!properties)

    static member inline CalendarSearch (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CalendarSearch" "lucide-react", createObj !!properties)

    static member inline CalendarX2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CalendarX2" "lucide-react", createObj !!properties)

    static member inline CalendarX (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CalendarX" "lucide-react", createObj !!properties)

    static member inline Calendar (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Calendar" "lucide-react", createObj !!properties)

    static member inline CameraOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CameraOff" "lucide-react", createObj !!properties)

    static member inline Camera (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Camera" "lucide-react", createObj !!properties)

    static member inline Car (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Car" "lucide-react", createObj !!properties)

    static member inline Carrot (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Carrot" "lucide-react", createObj !!properties)

    static member inline Cast (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Cast" "lucide-react", createObj !!properties)

    static member inline CheckCircle2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CheckCircle2" "lucide-react", createObj !!properties)

    static member inline CheckCircle (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CheckCircle" "lucide-react", createObj !!properties)

    static member inline CheckSquare (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CheckSquare" "lucide-react", createObj !!properties)

    static member inline Check (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Check" "lucide-react", createObj !!properties)

    static member inline ChefHat (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ChefHat" "lucide-react", createObj !!properties)

    static member inline Cherry (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Cherry" "lucide-react", createObj !!properties)

    static member inline ChevronDown (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ChevronDown" "lucide-react", createObj !!properties)

    static member inline ChevronFirst (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ChevronFirst" "lucide-react", createObj !!properties)

    static member inline ChevronLast (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ChevronLast" "lucide-react", createObj !!properties)

    static member inline ChevronLeft (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ChevronLeft" "lucide-react", createObj !!properties)

    static member inline ChevronRight (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ChevronRight" "lucide-react", createObj !!properties)

    static member inline ChevronUp (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ChevronUp" "lucide-react", createObj !!properties)

    static member inline ChevronsDownUp (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ChevronsDownUp" "lucide-react", createObj !!properties)

    static member inline ChevronsDown (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ChevronsDown" "lucide-react", createObj !!properties)

    static member inline ChevronsLeftRight (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ChevronsLeftRight" "lucide-react", createObj !!properties)

    static member inline ChevronsLeft (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ChevronsLeft" "lucide-react", createObj !!properties)

    static member inline ChevronsRightLeft (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ChevronsRightLeft" "lucide-react", createObj !!properties)

    static member inline ChevronsRight (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ChevronsRight" "lucide-react", createObj !!properties)

    static member inline ChevronsUpDown (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ChevronsUpDown" "lucide-react", createObj !!properties)

    static member inline ChevronsUp (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ChevronsUp" "lucide-react", createObj !!properties)

    static member inline Chrome (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Chrome" "lucide-react", createObj !!properties)

    static member inline CigaretteOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CigaretteOff" "lucide-react", createObj !!properties)

    static member inline Cigarette (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Cigarette" "lucide-react", createObj !!properties)

    static member inline CircleDot (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CircleDot" "lucide-react", createObj !!properties)

    static member inline CircleEllipsis (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CircleEllipsis" "lucide-react", createObj !!properties)

    static member inline CircleSlashed (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CircleSlashed" "lucide-react", createObj !!properties)

    static member inline Circle (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Circle" "lucide-react", createObj !!properties)

    static member inline Citrus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Citrus" "lucide-react", createObj !!properties)

    static member inline Clapperboard (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Clapperboard" "lucide-react", createObj !!properties)

    static member inline ClipboardCheck (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ClipboardCheck" "lucide-react", createObj !!properties)

    static member inline ClipboardCopy (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ClipboardCopy" "lucide-react", createObj !!properties)

    static member inline ClipboardEdit (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ClipboardEdit" "lucide-react", createObj !!properties)

    static member inline ClipboardList (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ClipboardList" "lucide-react", createObj !!properties)

    static member inline ClipboardSignature (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ClipboardSignature" "lucide-react", createObj !!properties)

    static member inline ClipboardType (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ClipboardType" "lucide-react", createObj !!properties)

    static member inline ClipboardX (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ClipboardX" "lucide-react", createObj !!properties)

    static member inline Clipboard (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Clipboard" "lucide-react", createObj !!properties)

    static member inline Clock1 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Clock1" "lucide-react", createObj !!properties)

    static member inline Clock10 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Clock10" "lucide-react", createObj !!properties)

    static member inline Clock11 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Clock11" "lucide-react", createObj !!properties)

    static member inline Clock12 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Clock12" "lucide-react", createObj !!properties)

    static member inline Clock2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Clock2" "lucide-react", createObj !!properties)

    static member inline Clock3 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Clock3" "lucide-react", createObj !!properties)

    static member inline Clock4 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Clock4" "lucide-react", createObj !!properties)

    static member inline Clock5 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Clock5" "lucide-react", createObj !!properties)

    static member inline Clock6 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Clock6" "lucide-react", createObj !!properties)

    static member inline Clock7 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Clock7" "lucide-react", createObj !!properties)

    static member inline Clock8 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Clock8" "lucide-react", createObj !!properties)

    static member inline Clock9 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Clock9" "lucide-react", createObj !!properties)

    static member inline Clock (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Clock" "lucide-react", createObj !!properties)

    static member inline CloudCog (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CloudCog" "lucide-react", createObj !!properties)

    static member inline CloudDrizzle (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CloudDrizzle" "lucide-react", createObj !!properties)

    static member inline CloudFog (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CloudFog" "lucide-react", createObj !!properties)

    static member inline CloudHail (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CloudHail" "lucide-react", createObj !!properties)

    static member inline CloudLightning (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CloudLightning" "lucide-react", createObj !!properties)

    static member inline CloudMoonRain (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CloudMoonRain" "lucide-react", createObj !!properties)

    static member inline CloudMoon (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CloudMoon" "lucide-react", createObj !!properties)

    static member inline CloudOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CloudOff" "lucide-react", createObj !!properties)

    static member inline CloudRainWind (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CloudRainWind" "lucide-react", createObj !!properties)

    static member inline CloudRain (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CloudRain" "lucide-react", createObj !!properties)

    static member inline CloudSnow (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CloudSnow" "lucide-react", createObj !!properties)

    static member inline CloudSunRain (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CloudSunRain" "lucide-react", createObj !!properties)

    static member inline CloudSun (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CloudSun" "lucide-react", createObj !!properties)

    static member inline Cloud (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Cloud" "lucide-react", createObj !!properties)

    static member inline Cloudy (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Cloudy" "lucide-react", createObj !!properties)

    static member inline Clover (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Clover" "lucide-react", createObj !!properties)

    static member inline Code2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Code2" "lucide-react", createObj !!properties)

    static member inline Code (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Code" "lucide-react", createObj !!properties)

    static member inline Codepen (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Codepen" "lucide-react", createObj !!properties)

    static member inline Codesandbox (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Codesandbox" "lucide-react", createObj !!properties)

    static member inline Coffee (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Coffee" "lucide-react", createObj !!properties)

    static member inline Cog (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Cog" "lucide-react", createObj !!properties)

    static member inline Coins (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Coins" "lucide-react", createObj !!properties)

    static member inline Columns (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Columns" "lucide-react", createObj !!properties)

    static member inline Command (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Command" "lucide-react", createObj !!properties)

    static member inline Compass (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Compass" "lucide-react", createObj !!properties)

    static member inline Component (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Component" "lucide-react", createObj !!properties)

    static member inline ConciergeBell (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ConciergeBell" "lucide-react", createObj !!properties)

    static member inline Contact (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Contact" "lucide-react", createObj !!properties)

    static member inline Contrast (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Contrast" "lucide-react", createObj !!properties)

    static member inline Cookie (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Cookie" "lucide-react", createObj !!properties)

    static member inline Copy (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Copy" "lucide-react", createObj !!properties)

    static member inline Copyleft (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Copyleft" "lucide-react", createObj !!properties)

    static member inline Copyright (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Copyright" "lucide-react", createObj !!properties)

    static member inline CornerDownLeft (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CornerDownLeft" "lucide-react", createObj !!properties)

    static member inline CornerDownRight (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CornerDownRight" "lucide-react", createObj !!properties)

    static member inline CornerLeftDown (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CornerLeftDown" "lucide-react", createObj !!properties)

    static member inline CornerLeftUp (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CornerLeftUp" "lucide-react", createObj !!properties)

    static member inline CornerRightDown (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CornerRightDown" "lucide-react", createObj !!properties)

    static member inline CornerRightUp (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CornerRightUp" "lucide-react", createObj !!properties)

    static member inline CornerUpLeft (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CornerUpLeft" "lucide-react", createObj !!properties)

    static member inline CornerUpRight (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CornerUpRight" "lucide-react", createObj !!properties)

    static member inline Cpu (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Cpu" "lucide-react", createObj !!properties)

    static member inline CreditCard (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CreditCard" "lucide-react", createObj !!properties)

    static member inline Croissant (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Croissant" "lucide-react", createObj !!properties)

    static member inline Crop (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Crop" "lucide-react", createObj !!properties)

    static member inline Cross (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Cross" "lucide-react", createObj !!properties)

    static member inline Crosshair (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Crosshair" "lucide-react", createObj !!properties)

    static member inline Crown (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Crown" "lucide-react", createObj !!properties)

    static member inline CupSoda (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CupSoda" "lucide-react", createObj !!properties)

    static member inline CurlyBraces (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "CurlyBraces" "lucide-react", createObj !!properties)

    static member inline Currency (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Currency" "lucide-react", createObj !!properties)

    static member inline Database (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Database" "lucide-react", createObj !!properties)

    static member inline Delete (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Delete" "lucide-react", createObj !!properties)

    static member inline Diamond (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Diamond" "lucide-react", createObj !!properties)

    static member inline Dice1 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Dice1" "lucide-react", createObj !!properties)

    static member inline Dice2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Dice2" "lucide-react", createObj !!properties)

    static member inline Dice3 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Dice3" "lucide-react", createObj !!properties)

    static member inline Dice4 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Dice4" "lucide-react", createObj !!properties)

    static member inline Dice5 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Dice5" "lucide-react", createObj !!properties)

    static member inline Dice6 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Dice6" "lucide-react", createObj !!properties)

    static member inline Dices (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Dices" "lucide-react", createObj !!properties)

    static member inline Diff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Diff" "lucide-react", createObj !!properties)

    static member inline Disc (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Disc" "lucide-react", createObj !!properties)

    static member inline DivideCircle (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "DivideCircle" "lucide-react", createObj !!properties)

    static member inline DivideSquare (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "DivideSquare" "lucide-react", createObj !!properties)

    static member inline Divide (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Divide" "lucide-react", createObj !!properties)

    static member inline DollarSign (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "DollarSign" "lucide-react", createObj !!properties)

    static member inline DownloadCloud (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "DownloadCloud" "lucide-react", createObj !!properties)

    static member inline Download (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Download" "lucide-react", createObj !!properties)

    static member inline Dribbble (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Dribbble" "lucide-react", createObj !!properties)

    static member inline Droplet (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Droplet" "lucide-react", createObj !!properties)

    static member inline Droplets (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Droplets" "lucide-react", createObj !!properties)

    static member inline Drumstick (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Drumstick" "lucide-react", createObj !!properties)

    static member inline Edit2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Edit2" "lucide-react", createObj !!properties)

    static member inline Edit3 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Edit3" "lucide-react", createObj !!properties)

    static member inline Edit (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Edit" "lucide-react", createObj !!properties)

    static member inline EggFried (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "EggFried" "lucide-react", createObj !!properties)

    static member inline Egg (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Egg" "lucide-react", createObj !!properties)

    static member inline EqualNot (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "EqualNot" "lucide-react", createObj !!properties)

    static member inline Equal (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Equal" "lucide-react", createObj !!properties)

    static member inline Eraser (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Eraser" "lucide-react", createObj !!properties)

    static member inline Euro (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Euro" "lucide-react", createObj !!properties)

    static member inline Expand (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Expand" "lucide-react", createObj !!properties)

    static member inline ExternalLink (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ExternalLink" "lucide-react", createObj !!properties)

    static member inline EyeOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "EyeOff" "lucide-react", createObj !!properties)

    static member inline Eye (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Eye" "lucide-react", createObj !!properties)

    static member inline Facebook (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Facebook" "lucide-react", createObj !!properties)

    static member inline Factory (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Factory" "lucide-react", createObj !!properties)

    static member inline Fan (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Fan" "lucide-react", createObj !!properties)

    static member inline FastForward (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FastForward" "lucide-react", createObj !!properties)

    static member inline Feather (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Feather" "lucide-react", createObj !!properties)

    static member inline Figma (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Figma" "lucide-react", createObj !!properties)

    static member inline FileArchive (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileArchive" "lucide-react", createObj !!properties)

    static member inline FileAudio2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileAudio2" "lucide-react", createObj !!properties)

    static member inline FileAudio (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileAudio" "lucide-react", createObj !!properties)

    static member inline FileAxis3d (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileAxis3d" "lucide-react", createObj !!properties)

    static member inline FileBadge2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileBadge2" "lucide-react", createObj !!properties)

    static member inline FileBadge (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileBadge" "lucide-react", createObj !!properties)

    static member inline FileBarChart2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileBarChart2" "lucide-react", createObj !!properties)

    static member inline FileBarChart (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileBarChart" "lucide-react", createObj !!properties)

    static member inline FileBox (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileBox" "lucide-react", createObj !!properties)

    static member inline FileCheck2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileCheck2" "lucide-react", createObj !!properties)

    static member inline FileCheck (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileCheck" "lucide-react", createObj !!properties)

    static member inline FileClock (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileClock" "lucide-react", createObj !!properties)

    static member inline FileCode (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileCode" "lucide-react", createObj !!properties)

    static member inline FileCog2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileCog2" "lucide-react", createObj !!properties)

    static member inline FileCog (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileCog" "lucide-react", createObj !!properties)

    static member inline FileDiff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileDiff" "lucide-react", createObj !!properties)

    static member inline FileDigit (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileDigit" "lucide-react", createObj !!properties)

    static member inline FileDown (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileDown" "lucide-react", createObj !!properties)

    static member inline FileEdit (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileEdit" "lucide-react", createObj !!properties)

    static member inline FileHeart (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileHeart" "lucide-react", createObj !!properties)

    static member inline FileImage (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileImage" "lucide-react", createObj !!properties)

    static member inline FileInput (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileInput" "lucide-react", createObj !!properties)

    static member inline FileJson2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileJson2" "lucide-react", createObj !!properties)

    static member inline FileJson (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileJson" "lucide-react", createObj !!properties)

    static member inline FileKey2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileKey2" "lucide-react", createObj !!properties)

    static member inline FileKey (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileKey" "lucide-react", createObj !!properties)

    static member inline FileLineChart (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileLineChart" "lucide-react", createObj !!properties)

    static member inline FileLock2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileLock2" "lucide-react", createObj !!properties)

    static member inline FileLock (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileLock" "lucide-react", createObj !!properties)

    static member inline FileMinus2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileMinus2" "lucide-react", createObj !!properties)

    static member inline FileMinus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileMinus" "lucide-react", createObj !!properties)

    static member inline FileOutput (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileOutput" "lucide-react", createObj !!properties)

    static member inline FilePieChart (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FilePieChart" "lucide-react", createObj !!properties)

    static member inline FilePlus2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FilePlus2" "lucide-react", createObj !!properties)

    static member inline FilePlus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FilePlus" "lucide-react", createObj !!properties)

    static member inline FileQuestion (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileQuestion" "lucide-react", createObj !!properties)

    static member inline FileScan (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileScan" "lucide-react", createObj !!properties)

    static member inline FileSearch2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileSearch2" "lucide-react", createObj !!properties)

    static member inline FileSearch (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileSearch" "lucide-react", createObj !!properties)

    static member inline FileSignature (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileSignature" "lucide-react", createObj !!properties)

    static member inline FileSpreadsheet (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileSpreadsheet" "lucide-react", createObj !!properties)

    static member inline FileSymlink (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileSymlink" "lucide-react", createObj !!properties)

    static member inline FileTerminal (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileTerminal" "lucide-react", createObj !!properties)

    static member inline FileText (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileText" "lucide-react", createObj !!properties)

    static member inline FileType2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileType2" "lucide-react", createObj !!properties)

    static member inline FileType (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileType" "lucide-react", createObj !!properties)

    static member inline FileUp (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileUp" "lucide-react", createObj !!properties)

    static member inline FileVideo2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileVideo2" "lucide-react", createObj !!properties)

    static member inline FileVideo (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileVideo" "lucide-react", createObj !!properties)

    static member inline FileVolume2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileVolume2" "lucide-react", createObj !!properties)

    static member inline FileVolume (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileVolume" "lucide-react", createObj !!properties)

    static member inline FileWarning (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileWarning" "lucide-react", createObj !!properties)

    static member inline FileX2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileX2" "lucide-react", createObj !!properties)

    static member inline FileX (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FileX" "lucide-react", createObj !!properties)

    static member inline File (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "File" "lucide-react", createObj !!properties)

    static member inline Files (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Files" "lucide-react", createObj !!properties)

    static member inline Film (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Film" "lucide-react", createObj !!properties)

    static member inline Filter (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Filter" "lucide-react", createObj !!properties)

    static member inline Fingerprint (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Fingerprint" "lucide-react", createObj !!properties)

    static member inline FlagOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FlagOff" "lucide-react", createObj !!properties)

    static member inline FlagTriangleLeft (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FlagTriangleLeft" "lucide-react", createObj !!properties)

    static member inline FlagTriangleRight (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FlagTriangleRight" "lucide-react", createObj !!properties)

    static member inline Flag (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Flag" "lucide-react", createObj !!properties)

    static member inline Flame (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Flame" "lucide-react", createObj !!properties)

    static member inline FlashlightOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FlashlightOff" "lucide-react", createObj !!properties)

    static member inline Flashlight (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Flashlight" "lucide-react", createObj !!properties)

    static member inline FlaskConical (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FlaskConical" "lucide-react", createObj !!properties)

    static member inline FlaskRound (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FlaskRound" "lucide-react", createObj !!properties)

    static member inline FlipHorizontal2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FlipHorizontal2" "lucide-react", createObj !!properties)

    static member inline FlipHorizontal (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FlipHorizontal" "lucide-react", createObj !!properties)

    static member inline FlipVertical2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FlipVertical2" "lucide-react", createObj !!properties)

    static member inline FlipVertical (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FlipVertical" "lucide-react", createObj !!properties)

    static member inline Flower2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Flower2" "lucide-react", createObj !!properties)

    static member inline Flower (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Flower" "lucide-react", createObj !!properties)

    static member inline Focus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Focus" "lucide-react", createObj !!properties)

    static member inline FolderArchive (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FolderArchive" "lucide-react", createObj !!properties)

    static member inline FolderCheck (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FolderCheck" "lucide-react", createObj !!properties)

    static member inline FolderClock (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FolderClock" "lucide-react", createObj !!properties)

    static member inline FolderClosed (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FolderClosed" "lucide-react", createObj !!properties)

    static member inline FolderCog2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FolderCog2" "lucide-react", createObj !!properties)

    static member inline FolderCog (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FolderCog" "lucide-react", createObj !!properties)

    static member inline FolderDown (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FolderDown" "lucide-react", createObj !!properties)

    static member inline FolderEdit (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FolderEdit" "lucide-react", createObj !!properties)

    static member inline FolderHeart (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FolderHeart" "lucide-react", createObj !!properties)

    static member inline FolderInput (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FolderInput" "lucide-react", createObj !!properties)

    static member inline FolderKey (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FolderKey" "lucide-react", createObj !!properties)

    static member inline FolderLock (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FolderLock" "lucide-react", createObj !!properties)

    static member inline FolderMinus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FolderMinus" "lucide-react", createObj !!properties)

    static member inline FolderOpen (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FolderOpen" "lucide-react", createObj !!properties)

    static member inline FolderOutput (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FolderOutput" "lucide-react", createObj !!properties)

    static member inline FolderPlus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FolderPlus" "lucide-react", createObj !!properties)

    static member inline FolderSearch2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FolderSearch2" "lucide-react", createObj !!properties)

    static member inline FolderSearch (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FolderSearch" "lucide-react", createObj !!properties)

    static member inline FolderSymlink (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FolderSymlink" "lucide-react", createObj !!properties)

    static member inline FolderTree (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FolderTree" "lucide-react", createObj !!properties)

    static member inline FolderUp (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FolderUp" "lucide-react", createObj !!properties)

    static member inline FolderX (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FolderX" "lucide-react", createObj !!properties)

    static member inline Folder (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Folder" "lucide-react", createObj !!properties)

    static member inline Folders (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Folders" "lucide-react", createObj !!properties)

    static member inline FormInput (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FormInput" "lucide-react", createObj !!properties)

    static member inline Forward (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Forward" "lucide-react", createObj !!properties)

    static member inline Frame (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Frame" "lucide-react", createObj !!properties)

    static member inline Framer (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Framer" "lucide-react", createObj !!properties)

    static member inline Frown (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Frown" "lucide-react", createObj !!properties)

    static member inline Fuel (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Fuel" "lucide-react", createObj !!properties)

    static member inline FunctionSquare (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "FunctionSquare" "lucide-react", createObj !!properties)

    static member inline Gamepad2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Gamepad2" "lucide-react", createObj !!properties)

    static member inline Gamepad (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Gamepad" "lucide-react", createObj !!properties)

    static member inline Gauge (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Gauge" "lucide-react", createObj !!properties)

    static member inline Gavel (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Gavel" "lucide-react", createObj !!properties)

    static member inline Gem (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Gem" "lucide-react", createObj !!properties)

    static member inline Ghost (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Ghost" "lucide-react", createObj !!properties)

    static member inline Gift (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Gift" "lucide-react", createObj !!properties)

    static member inline GitBranchPlus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "GitBranchPlus" "lucide-react", createObj !!properties)

    static member inline GitBranch (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "GitBranch" "lucide-react", createObj !!properties)

    static member inline GitCommit (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "GitCommit" "lucide-react", createObj !!properties)

    static member inline GitCompare (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "GitCompare" "lucide-react", createObj !!properties)

    static member inline GitFork (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "GitFork" "lucide-react", createObj !!properties)

    static member inline GitMerge (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "GitMerge" "lucide-react", createObj !!properties)

    static member inline GitPullRequestClosed (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "GitPullRequestClosed" "lucide-react", createObj !!properties)

    static member inline GitPullRequestDraft (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "GitPullRequestDraft" "lucide-react", createObj !!properties)

    static member inline GitPullRequest (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "GitPullRequest" "lucide-react", createObj !!properties)

    static member inline Github (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Github" "lucide-react", createObj !!properties)

    static member inline Gitlab (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Gitlab" "lucide-react", createObj !!properties)

    static member inline GlassWater (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "GlassWater" "lucide-react", createObj !!properties)

    static member inline Glasses (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Glasses" "lucide-react", createObj !!properties)

    static member inline Globe2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Globe2" "lucide-react", createObj !!properties)

    static member inline Globe (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Globe" "lucide-react", createObj !!properties)

    static member inline Grab (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Grab" "lucide-react", createObj !!properties)

    static member inline GraduationCap (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "GraduationCap" "lucide-react", createObj !!properties)

    static member inline Grape (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Grape" "lucide-react", createObj !!properties)

    static member inline Grid (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Grid" "lucide-react", createObj !!properties)

    static member inline GripHorizontal (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "GripHorizontal" "lucide-react", createObj !!properties)

    static member inline GripVertical (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "GripVertical" "lucide-react", createObj !!properties)

    static member inline Hammer (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Hammer" "lucide-react", createObj !!properties)

    static member inline HandMetal (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "HandMetal" "lucide-react", createObj !!properties)

    static member inline Hand (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Hand" "lucide-react", createObj !!properties)

    static member inline HardDrive (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "HardDrive" "lucide-react", createObj !!properties)

    static member inline HardHat (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "HardHat" "lucide-react", createObj !!properties)

    static member inline Hash (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Hash" "lucide-react", createObj !!properties)

    static member inline Haze (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Haze" "lucide-react", createObj !!properties)

    static member inline Headphones (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Headphones" "lucide-react", createObj !!properties)

    static member inline HeartCrack (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "HeartCrack" "lucide-react", createObj !!properties)

    static member inline HeartHandshake (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "HeartHandshake" "lucide-react", createObj !!properties)

    static member inline HeartOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "HeartOff" "lucide-react", createObj !!properties)

    static member inline HeartPulse (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "HeartPulse" "lucide-react", createObj !!properties)

    static member inline Heart (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Heart" "lucide-react", createObj !!properties)

    static member inline HelpCircle (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "HelpCircle" "lucide-react", createObj !!properties)

    static member inline Hexagon (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Hexagon" "lucide-react", createObj !!properties)

    static member inline Highlighter (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Highlighter" "lucide-react", createObj !!properties)

    static member inline History (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "History" "lucide-react", createObj !!properties)

    static member inline Home (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Home" "lucide-react", createObj !!properties)

    static member inline Hourglass (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Hourglass" "lucide-react", createObj !!properties)

    static member inline IceCream (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "IceCream" "lucide-react", createObj !!properties)

    static member inline ImageMinus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ImageMinus" "lucide-react", createObj !!properties)

    static member inline ImageOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ImageOff" "lucide-react", createObj !!properties)

    static member inline ImagePlus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ImagePlus" "lucide-react", createObj !!properties)

    static member inline Image (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Image" "lucide-react", createObj !!properties)

    static member inline Import (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Import" "lucide-react", createObj !!properties)

    static member inline Inbox (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Inbox" "lucide-react", createObj !!properties)

    static member inline Indent (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Indent" "lucide-react", createObj !!properties)

    static member inline IndianRupee (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "IndianRupee" "lucide-react", createObj !!properties)

    static member inline Infinity (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Infinity" "lucide-react", createObj !!properties)

    static member inline Info (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Info" "lucide-react", createObj !!properties)

    static member inline Inspect (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Inspect" "lucide-react", createObj !!properties)

    static member inline Instagram (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Instagram" "lucide-react", createObj !!properties)

    static member inline Italic (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Italic" "lucide-react", createObj !!properties)

    static member inline JapaneseYen (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "JapaneseYen" "lucide-react", createObj !!properties)

    static member inline Joystick (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Joystick" "lucide-react", createObj !!properties)

    static member inline Key (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Key" "lucide-react", createObj !!properties)

    static member inline Keyboard (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Keyboard" "lucide-react", createObj !!properties)

    static member inline LampCeiling (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "LampCeiling" "lucide-react", createObj !!properties)

    static member inline LampDesk (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "LampDesk" "lucide-react", createObj !!properties)

    static member inline LampFloor (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "LampFloor" "lucide-react", createObj !!properties)

    static member inline LampWallDown (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "LampWallDown" "lucide-react", createObj !!properties)

    static member inline LampWallUp (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "LampWallUp" "lucide-react", createObj !!properties)

    static member inline Lamp (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Lamp" "lucide-react", createObj !!properties)

    static member inline Landmark (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Landmark" "lucide-react", createObj !!properties)

    static member inline Languages (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Languages" "lucide-react", createObj !!properties)

    static member inline Laptop2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Laptop2" "lucide-react", createObj !!properties)

    static member inline Laptop (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Laptop" "lucide-react", createObj !!properties)

    static member inline LassoSelect (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "LassoSelect" "lucide-react", createObj !!properties)

    static member inline Lasso (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Lasso" "lucide-react", createObj !!properties)

    static member inline Laugh (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Laugh" "lucide-react", createObj !!properties)

    static member inline Layers (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Layers" "lucide-react", createObj !!properties)

    static member inline LayoutDashboard (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "LayoutDashboard" "lucide-react", createObj !!properties)

    static member inline LayoutGrid (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "LayoutGrid" "lucide-react", createObj !!properties)

    static member inline LayoutList (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "LayoutList" "lucide-react", createObj !!properties)

    static member inline LayoutTemplate (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "LayoutTemplate" "lucide-react", createObj !!properties)

    static member inline Layout (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Layout" "lucide-react", createObj !!properties)

    static member inline Leaf (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Leaf" "lucide-react", createObj !!properties)

    static member inline Library (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Library" "lucide-react", createObj !!properties)

    static member inline LifeBuoy (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "LifeBuoy" "lucide-react", createObj !!properties)

    static member inline LightbulbOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "LightbulbOff" "lucide-react", createObj !!properties)

    static member inline Lightbulb (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Lightbulb" "lucide-react", createObj !!properties)

    static member inline LineChart (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "LineChart" "lucide-react", createObj !!properties)

    static member inline Link2Off (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Link2Off" "lucide-react", createObj !!properties)

    static member inline Link2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Link2" "lucide-react", createObj !!properties)

    static member inline Link (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Link" "lucide-react", createObj !!properties)

    static member inline Linkedin (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Linkedin" "lucide-react", createObj !!properties)

    static member inline ListChecks (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ListChecks" "lucide-react", createObj !!properties)

    static member inline ListEnd (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ListEnd" "lucide-react", createObj !!properties)

    static member inline ListMinus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ListMinus" "lucide-react", createObj !!properties)

    static member inline ListMusic (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ListMusic" "lucide-react", createObj !!properties)

    static member inline ListOrdered (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ListOrdered" "lucide-react", createObj !!properties)

    static member inline ListPlus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ListPlus" "lucide-react", createObj !!properties)

    static member inline ListStart (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ListStart" "lucide-react", createObj !!properties)

    static member inline ListVideo (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ListVideo" "lucide-react", createObj !!properties)

    static member inline ListX (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ListX" "lucide-react", createObj !!properties)

    static member inline List (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "List" "lucide-react", createObj !!properties)

    static member inline Loader2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Loader2" "lucide-react", createObj !!properties)

    static member inline Loader (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Loader" "lucide-react", createObj !!properties)

    static member inline LocateFixed (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "LocateFixed" "lucide-react", createObj !!properties)

    static member inline LocateOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "LocateOff" "lucide-react", createObj !!properties)

    static member inline Locate (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Locate" "lucide-react", createObj !!properties)

    static member inline Lock (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Lock" "lucide-react", createObj !!properties)

    static member inline LogIn (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "LogIn" "lucide-react", createObj !!properties)

    static member inline LogOut (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "LogOut" "lucide-react", createObj !!properties)

    static member inline Luggage (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Luggage" "lucide-react", createObj !!properties)

    static member inline Magnet (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Magnet" "lucide-react", createObj !!properties)

    static member inline MailCheck (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MailCheck" "lucide-react", createObj !!properties)

    static member inline MailMinus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MailMinus" "lucide-react", createObj !!properties)

    static member inline MailOpen (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MailOpen" "lucide-react", createObj !!properties)

    static member inline MailPlus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MailPlus" "lucide-react", createObj !!properties)

    static member inline MailQuestion (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MailQuestion" "lucide-react", createObj !!properties)

    static member inline MailSearch (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MailSearch" "lucide-react", createObj !!properties)

    static member inline MailWarning (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MailWarning" "lucide-react", createObj !!properties)

    static member inline MailX (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MailX" "lucide-react", createObj !!properties)

    static member inline Mail (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Mail" "lucide-react", createObj !!properties)

    static member inline Mails (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Mails" "lucide-react", createObj !!properties)

    static member inline MapPinOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MapPinOff" "lucide-react", createObj !!properties)

    static member inline MapPin (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MapPin" "lucide-react", createObj !!properties)

    static member inline Map (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Map" "lucide-react", createObj !!properties)

    static member inline Martini (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Martini" "lucide-react", createObj !!properties)

    static member inline Maximize2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Maximize2" "lucide-react", createObj !!properties)

    static member inline Maximize (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Maximize" "lucide-react", createObj !!properties)

    static member inline Medal (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Medal" "lucide-react", createObj !!properties)

    static member inline MegaphoneOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MegaphoneOff" "lucide-react", createObj !!properties)

    static member inline Megaphone (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Megaphone" "lucide-react", createObj !!properties)

    static member inline Meh (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Meh" "lucide-react", createObj !!properties)

    static member inline Menu (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Menu" "lucide-react", createObj !!properties)

    static member inline MessageCircle (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MessageCircle" "lucide-react", createObj !!properties)

    static member inline MessageSquare (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MessageSquare" "lucide-react", createObj !!properties)

    static member inline Mic2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Mic2" "lucide-react", createObj !!properties)

    static member inline MicOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MicOff" "lucide-react", createObj !!properties)

    static member inline Mic (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Mic" "lucide-react", createObj !!properties)

    static member inline Microscope (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Microscope" "lucide-react", createObj !!properties)

    static member inline Microwave (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Microwave" "lucide-react", createObj !!properties)

    static member inline Milestone (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Milestone" "lucide-react", createObj !!properties)

    static member inline Minimize2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Minimize2" "lucide-react", createObj !!properties)

    static member inline Minimize (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Minimize" "lucide-react", createObj !!properties)

    static member inline MinusCircle (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MinusCircle" "lucide-react", createObj !!properties)

    static member inline MinusSquare (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MinusSquare" "lucide-react", createObj !!properties)

    static member inline Minus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Minus" "lucide-react", createObj !!properties)

    static member inline MonitorOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MonitorOff" "lucide-react", createObj !!properties)

    static member inline MonitorSpeaker (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MonitorSpeaker" "lucide-react", createObj !!properties)

    static member inline Monitor (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Monitor" "lucide-react", createObj !!properties)

    static member inline Moon (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Moon" "lucide-react", createObj !!properties)

    static member inline MoreHorizontal (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MoreHorizontal" "lucide-react", createObj !!properties)

    static member inline MoreVertical (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MoreVertical" "lucide-react", createObj !!properties)

    static member inline MountainSnow (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MountainSnow" "lucide-react", createObj !!properties)

    static member inline Mountain (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Mountain" "lucide-react", createObj !!properties)

    static member inline MousePointer2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MousePointer2" "lucide-react", createObj !!properties)

    static member inline MousePointerClick (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MousePointerClick" "lucide-react", createObj !!properties)

    static member inline MousePointer (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MousePointer" "lucide-react", createObj !!properties)

    static member inline Mouse (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Mouse" "lucide-react", createObj !!properties)

    static member inline Move3d (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Move3d" "lucide-react", createObj !!properties)

    static member inline MoveDiagonal2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MoveDiagonal2" "lucide-react", createObj !!properties)

    static member inline MoveDiagonal (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MoveDiagonal" "lucide-react", createObj !!properties)

    static member inline MoveHorizontal (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MoveHorizontal" "lucide-react", createObj !!properties)

    static member inline MoveVertical (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "MoveVertical" "lucide-react", createObj !!properties)

    static member inline Move (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Move" "lucide-react", createObj !!properties)

    static member inline Music2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Music2" "lucide-react", createObj !!properties)

    static member inline Music3 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Music3" "lucide-react", createObj !!properties)

    static member inline Music4 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Music4" "lucide-react", createObj !!properties)

    static member inline Music (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Music" "lucide-react", createObj !!properties)

    static member inline Navigation2Off (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Navigation2Off" "lucide-react", createObj !!properties)

    static member inline Navigation2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Navigation2" "lucide-react", createObj !!properties)

    static member inline NavigationOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "NavigationOff" "lucide-react", createObj !!properties)

    static member inline Navigation (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Navigation" "lucide-react", createObj !!properties)

    static member inline Network (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Network" "lucide-react", createObj !!properties)

    static member inline Newspaper (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Newspaper" "lucide-react", createObj !!properties)

    static member inline Octagon (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Octagon" "lucide-react", createObj !!properties)

    static member inline Option (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Option" "lucide-react", createObj !!properties)

    static member inline Outdent (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Outdent" "lucide-react", createObj !!properties)

    static member inline Package2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Package2" "lucide-react", createObj !!properties)

    static member inline PackageCheck (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PackageCheck" "lucide-react", createObj !!properties)

    static member inline PackageMinus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PackageMinus" "lucide-react", createObj !!properties)

    static member inline PackageOpen (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PackageOpen" "lucide-react", createObj !!properties)

    static member inline PackagePlus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PackagePlus" "lucide-react", createObj !!properties)

    static member inline PackageSearch (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PackageSearch" "lucide-react", createObj !!properties)

    static member inline PackageX (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PackageX" "lucide-react", createObj !!properties)

    static member inline Package (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Package" "lucide-react", createObj !!properties)

    static member inline PaintBucket (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PaintBucket" "lucide-react", createObj !!properties)

    static member inline Paintbrush2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Paintbrush2" "lucide-react", createObj !!properties)

    static member inline Paintbrush (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Paintbrush" "lucide-react", createObj !!properties)

    static member inline Palette (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Palette" "lucide-react", createObj !!properties)

    static member inline Palmtree (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Palmtree" "lucide-react", createObj !!properties)

    static member inline Paperclip (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Paperclip" "lucide-react", createObj !!properties)

    static member inline PartyPopper (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PartyPopper" "lucide-react", createObj !!properties)

    static member inline PauseCircle (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PauseCircle" "lucide-react", createObj !!properties)

    static member inline PauseOctagon (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PauseOctagon" "lucide-react", createObj !!properties)

    static member inline Pause (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Pause" "lucide-react", createObj !!properties)

    static member inline PenTool (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PenTool" "lucide-react", createObj !!properties)

    static member inline Pencil (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Pencil" "lucide-react", createObj !!properties)

    static member inline Percent (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Percent" "lucide-react", createObj !!properties)

    static member inline PersonStanding (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PersonStanding" "lucide-react", createObj !!properties)

    static member inline PhoneCall (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PhoneCall" "lucide-react", createObj !!properties)

    static member inline PhoneForwarded (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PhoneForwarded" "lucide-react", createObj !!properties)

    static member inline PhoneIncoming (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PhoneIncoming" "lucide-react", createObj !!properties)

    static member inline PhoneMissed (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PhoneMissed" "lucide-react", createObj !!properties)

    static member inline PhoneOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PhoneOff" "lucide-react", createObj !!properties)

    static member inline PhoneOutgoing (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PhoneOutgoing" "lucide-react", createObj !!properties)

    static member inline Phone (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Phone" "lucide-react", createObj !!properties)

    static member inline PieChart (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PieChart" "lucide-react", createObj !!properties)

    static member inline PiggyBank (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PiggyBank" "lucide-react", createObj !!properties)

    static member inline PinOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PinOff" "lucide-react", createObj !!properties)

    static member inline Pin (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Pin" "lucide-react", createObj !!properties)

    static member inline Pipette (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Pipette" "lucide-react", createObj !!properties)

    static member inline Pizza (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Pizza" "lucide-react", createObj !!properties)

    static member inline Plane (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Plane" "lucide-react", createObj !!properties)

    static member inline PlayCircle (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PlayCircle" "lucide-react", createObj !!properties)

    static member inline Play (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Play" "lucide-react", createObj !!properties)

    static member inline Plug2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Plug2" "lucide-react", createObj !!properties)

    static member inline PlugZap (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PlugZap" "lucide-react", createObj !!properties)

    static member inline Plug (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Plug" "lucide-react", createObj !!properties)

    static member inline PlusCircle (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PlusCircle" "lucide-react", createObj !!properties)

    static member inline PlusSquare (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PlusSquare" "lucide-react", createObj !!properties)

    static member inline Plus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Plus" "lucide-react", createObj !!properties)

    static member inline Pocket (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Pocket" "lucide-react", createObj !!properties)

    static member inline Podcast (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Podcast" "lucide-react", createObj !!properties)

    static member inline Pointer (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Pointer" "lucide-react", createObj !!properties)

    static member inline PoundSterling (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PoundSterling" "lucide-react", createObj !!properties)

    static member inline PowerOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "PowerOff" "lucide-react", createObj !!properties)

    static member inline Power (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Power" "lucide-react", createObj !!properties)

    static member inline Printer (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Printer" "lucide-react", createObj !!properties)

    static member inline Puzzle (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Puzzle" "lucide-react", createObj !!properties)

    static member inline QrCode (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "QrCode" "lucide-react", createObj !!properties)

    static member inline Quote (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Quote" "lucide-react", createObj !!properties)

    static member inline RadioReceiver (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "RadioReceiver" "lucide-react", createObj !!properties)

    static member inline Radio (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Radio" "lucide-react", createObj !!properties)

    static member inline RectangleHorizontal (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "RectangleHorizontal" "lucide-react", createObj !!properties)

    static member inline RectangleVertical (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "RectangleVertical" "lucide-react", createObj !!properties)

    static member inline Recycle (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Recycle" "lucide-react", createObj !!properties)

    static member inline Redo2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Redo2" "lucide-react", createObj !!properties)

    static member inline Redo (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Redo" "lucide-react", createObj !!properties)

    static member inline RefreshCcw (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "RefreshCcw" "lucide-react", createObj !!properties)

    static member inline RefreshCw (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "RefreshCw" "lucide-react", createObj !!properties)

    static member inline Refrigerator (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Refrigerator" "lucide-react", createObj !!properties)

    static member inline Regex (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Regex" "lucide-react", createObj !!properties)

    static member inline Repeat1 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Repeat1" "lucide-react", createObj !!properties)

    static member inline Repeat (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Repeat" "lucide-react", createObj !!properties)

    static member inline ReplyAll (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ReplyAll" "lucide-react", createObj !!properties)

    static member inline Reply (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Reply" "lucide-react", createObj !!properties)

    static member inline Rewind (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Rewind" "lucide-react", createObj !!properties)

    static member inline Rocket (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Rocket" "lucide-react", createObj !!properties)

    static member inline RockingChair (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "RockingChair" "lucide-react", createObj !!properties)

    static member inline Rotate3d (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Rotate3d" "lucide-react", createObj !!properties)

    static member inline RotateCcw (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "RotateCcw" "lucide-react", createObj !!properties)

    static member inline RotateCw (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "RotateCw" "lucide-react", createObj !!properties)

    static member inline Rss (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Rss" "lucide-react", createObj !!properties)

    static member inline Ruler (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Ruler" "lucide-react", createObj !!properties)

    static member inline RussianRuble (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "RussianRuble" "lucide-react", createObj !!properties)

    static member inline Sailboat (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Sailboat" "lucide-react", createObj !!properties)

    static member inline Save (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Save" "lucide-react", createObj !!properties)

    static member inline Scale3d (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Scale3d" "lucide-react", createObj !!properties)

    static member inline Scale (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Scale" "lucide-react", createObj !!properties)

    static member inline Scaling (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Scaling" "lucide-react", createObj !!properties)

    static member inline ScanFace (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ScanFace" "lucide-react", createObj !!properties)

    static member inline ScanLine (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ScanLine" "lucide-react", createObj !!properties)

    static member inline Scan (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Scan" "lucide-react", createObj !!properties)

    static member inline Scissors (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Scissors" "lucide-react", createObj !!properties)

    static member inline ScreenShareOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ScreenShareOff" "lucide-react", createObj !!properties)

    static member inline ScreenShare (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ScreenShare" "lucide-react", createObj !!properties)

    static member inline Scroll (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Scroll" "lucide-react", createObj !!properties)

    static member inline Search (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Search" "lucide-react", createObj !!properties)

    static member inline Send (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Send" "lucide-react", createObj !!properties)

    static member inline SeparatorHorizontal (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "SeparatorHorizontal" "lucide-react", createObj !!properties)

    static member inline SeparatorVertical (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "SeparatorVertical" "lucide-react", createObj !!properties)

    static member inline ServerCog (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ServerCog" "lucide-react", createObj !!properties)

    static member inline ServerCrash (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ServerCrash" "lucide-react", createObj !!properties)

    static member inline ServerOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ServerOff" "lucide-react", createObj !!properties)

    static member inline Server (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Server" "lucide-react", createObj !!properties)

    static member inline Settings2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Settings2" "lucide-react", createObj !!properties)

    static member inline Settings (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Settings" "lucide-react", createObj !!properties)

    static member inline Share2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Share2" "lucide-react", createObj !!properties)

    static member inline Share (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Share" "lucide-react", createObj !!properties)

    static member inline Sheet (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Sheet" "lucide-react", createObj !!properties)

    static member inline ShieldAlert (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ShieldAlert" "lucide-react", createObj !!properties)

    static member inline ShieldCheck (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ShieldCheck" "lucide-react", createObj !!properties)

    static member inline ShieldClose (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ShieldClose" "lucide-react", createObj !!properties)

    static member inline ShieldOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ShieldOff" "lucide-react", createObj !!properties)

    static member inline Shield (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Shield" "lucide-react", createObj !!properties)

    static member inline Shirt (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Shirt" "lucide-react", createObj !!properties)

    static member inline ShoppingBag (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ShoppingBag" "lucide-react", createObj !!properties)

    static member inline ShoppingCart (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ShoppingCart" "lucide-react", createObj !!properties)

    static member inline Shovel (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Shovel" "lucide-react", createObj !!properties)

    static member inline ShowerHead (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ShowerHead" "lucide-react", createObj !!properties)

    static member inline Shrink (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Shrink" "lucide-react", createObj !!properties)

    static member inline Shrub (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Shrub" "lucide-react", createObj !!properties)

    static member inline Shuffle (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Shuffle" "lucide-react", createObj !!properties)

    static member inline SidebarClose (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "SidebarClose" "lucide-react", createObj !!properties)

    static member inline SidebarOpen (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "SidebarOpen" "lucide-react", createObj !!properties)

    static member inline Sidebar (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Sidebar" "lucide-react", createObj !!properties)

    static member inline Sigma (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Sigma" "lucide-react", createObj !!properties)

    static member inline SignalHigh (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "SignalHigh" "lucide-react", createObj !!properties)

    static member inline SignalLow (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "SignalLow" "lucide-react", createObj !!properties)

    static member inline SignalMedium (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "SignalMedium" "lucide-react", createObj !!properties)

    static member inline SignalZero (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "SignalZero" "lucide-react", createObj !!properties)

    static member inline Signal (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Signal" "lucide-react", createObj !!properties)

    static member inline Siren (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Siren" "lucide-react", createObj !!properties)

    static member inline SkipBack (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "SkipBack" "lucide-react", createObj !!properties)

    static member inline SkipForward (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "SkipForward" "lucide-react", createObj !!properties)

    static member inline Skull (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Skull" "lucide-react", createObj !!properties)

    static member inline Slack (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Slack" "lucide-react", createObj !!properties)

    static member inline Slash (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Slash" "lucide-react", createObj !!properties)

    static member inline Slice (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Slice" "lucide-react", createObj !!properties)

    static member inline SlidersHorizontal (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "SlidersHorizontal" "lucide-react", createObj !!properties)

    static member inline Sliders (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Sliders" "lucide-react", createObj !!properties)

    static member inline SmartphoneCharging (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "SmartphoneCharging" "lucide-react", createObj !!properties)

    static member inline Smartphone (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Smartphone" "lucide-react", createObj !!properties)

    static member inline SmilePlus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "SmilePlus" "lucide-react", createObj !!properties)

    static member inline Smile (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Smile" "lucide-react", createObj !!properties)

    static member inline Snowflake (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Snowflake" "lucide-react", createObj !!properties)

    static member inline Sofa (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Sofa" "lucide-react", createObj !!properties)

    static member inline SortAsc (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "SortAsc" "lucide-react", createObj !!properties)

    static member inline SortDesc (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "SortDesc" "lucide-react", createObj !!properties)

    static member inline Speaker (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Speaker" "lucide-react", createObj !!properties)

    static member inline Sprout (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Sprout" "lucide-react", createObj !!properties)

    static member inline Square (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Square" "lucide-react", createObj !!properties)

    static member inline StarHalf (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "StarHalf" "lucide-react", createObj !!properties)

    static member inline StarOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "StarOff" "lucide-react", createObj !!properties)

    static member inline Star (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Star" "lucide-react", createObj !!properties)

    static member inline Stethoscope (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Stethoscope" "lucide-react", createObj !!properties)

    static member inline Sticker (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Sticker" "lucide-react", createObj !!properties)

    static member inline StickyNote (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "StickyNote" "lucide-react", createObj !!properties)

    static member inline StopCircle (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "StopCircle" "lucide-react", createObj !!properties)

    static member inline StretchHorizontal (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "StretchHorizontal" "lucide-react", createObj !!properties)

    static member inline StretchVertical (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "StretchVertical" "lucide-react", createObj !!properties)

    static member inline Strikethrough (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Strikethrough" "lucide-react", createObj !!properties)

    static member inline Subscript (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Subscript" "lucide-react", createObj !!properties)

    static member inline SunDim (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "SunDim" "lucide-react", createObj !!properties)

    static member inline SunMedium (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "SunMedium" "lucide-react", createObj !!properties)

    static member inline SunMoon (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "SunMoon" "lucide-react", createObj !!properties)

    static member inline SunSnow (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "SunSnow" "lucide-react", createObj !!properties)

    static member inline Sun (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Sun" "lucide-react", createObj !!properties)

    static member inline Sunrise (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Sunrise" "lucide-react", createObj !!properties)

    static member inline Sunset (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Sunset" "lucide-react", createObj !!properties)

    static member inline Superscript (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Superscript" "lucide-react", createObj !!properties)

    static member inline SwissFranc (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "SwissFranc" "lucide-react", createObj !!properties)

    static member inline SwitchCamera (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "SwitchCamera" "lucide-react", createObj !!properties)

    static member inline Sword (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Sword" "lucide-react", createObj !!properties)

    static member inline Swords (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Swords" "lucide-react", createObj !!properties)

    static member inline Syringe (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Syringe" "lucide-react", createObj !!properties)

    static member inline Table2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Table2" "lucide-react", createObj !!properties)

    static member inline Table (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Table" "lucide-react", createObj !!properties)

    static member inline Tablet (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Tablet" "lucide-react", createObj !!properties)

    static member inline Tag (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Tag" "lucide-react", createObj !!properties)

    static member inline Tags (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Tags" "lucide-react", createObj !!properties)

    static member inline Target (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Target" "lucide-react", createObj !!properties)

    static member inline Tent (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Tent" "lucide-react", createObj !!properties)

    static member inline TerminalSquare (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "TerminalSquare" "lucide-react", createObj !!properties)

    static member inline Terminal (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Terminal" "lucide-react", createObj !!properties)

    static member inline TextCursorInput (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "TextCursorInput" "lucide-react", createObj !!properties)

    static member inline TextCursor (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "TextCursor" "lucide-react", createObj !!properties)

    static member inline ThermometerSnowflake (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ThermometerSnowflake" "lucide-react", createObj !!properties)

    static member inline ThermometerSun (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ThermometerSun" "lucide-react", createObj !!properties)

    static member inline Thermometer (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Thermometer" "lucide-react", createObj !!properties)

    static member inline ThumbsDown (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ThumbsDown" "lucide-react", createObj !!properties)

    static member inline ThumbsUp (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ThumbsUp" "lucide-react", createObj !!properties)

    static member inline Ticket (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Ticket" "lucide-react", createObj !!properties)

    static member inline TimerOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "TimerOff" "lucide-react", createObj !!properties)

    static member inline TimerReset (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "TimerReset" "lucide-react", createObj !!properties)

    static member inline Timer (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Timer" "lucide-react", createObj !!properties)

    static member inline ToggleLeft (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ToggleLeft" "lucide-react", createObj !!properties)

    static member inline ToggleRight (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ToggleRight" "lucide-react", createObj !!properties)

    static member inline Tornado (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Tornado" "lucide-react", createObj !!properties)

    static member inline ToyBrick (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ToyBrick" "lucide-react", createObj !!properties)

    static member inline Train (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Train" "lucide-react", createObj !!properties)

    static member inline Trash2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Trash2" "lucide-react", createObj !!properties)

    static member inline Trash (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Trash" "lucide-react", createObj !!properties)

    static member inline TreeDeciduous (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "TreeDeciduous" "lucide-react", createObj !!properties)

    static member inline TreePine (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "TreePine" "lucide-react", createObj !!properties)

    static member inline Trees (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Trees" "lucide-react", createObj !!properties)

    static member inline Trello (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Trello" "lucide-react", createObj !!properties)

    static member inline TrendingDown (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "TrendingDown" "lucide-react", createObj !!properties)

    static member inline TrendingUp (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "TrendingUp" "lucide-react", createObj !!properties)

    static member inline Triangle (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Triangle" "lucide-react", createObj !!properties)

    static member inline Trophy (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Trophy" "lucide-react", createObj !!properties)

    static member inline Truck (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Truck" "lucide-react", createObj !!properties)

    static member inline Tv2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Tv2" "lucide-react", createObj !!properties)

    static member inline Tv (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Tv" "lucide-react", createObj !!properties)

    static member inline Twitch (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Twitch" "lucide-react", createObj !!properties)

    static member inline Twitter (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Twitter" "lucide-react", createObj !!properties)

    static member inline Type (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Type" "lucide-react", createObj !!properties)

    static member inline Umbrella (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Umbrella" "lucide-react", createObj !!properties)

    static member inline Underline (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Underline" "lucide-react", createObj !!properties)

    static member inline Undo2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Undo2" "lucide-react", createObj !!properties)

    static member inline Undo (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Undo" "lucide-react", createObj !!properties)

    static member inline Unlink2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Unlink2" "lucide-react", createObj !!properties)

    static member inline Unlink (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Unlink" "lucide-react", createObj !!properties)

    static member inline Unlock (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Unlock" "lucide-react", createObj !!properties)

    static member inline UploadCloud (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "UploadCloud" "lucide-react", createObj !!properties)

    static member inline Upload (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Upload" "lucide-react", createObj !!properties)

    static member inline Usb (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Usb" "lucide-react", createObj !!properties)

    static member inline UserCheck (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "UserCheck" "lucide-react", createObj !!properties)

    static member inline UserCog (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "UserCog" "lucide-react", createObj !!properties)

    static member inline UserMinus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "UserMinus" "lucide-react", createObj !!properties)

    static member inline UserPlus (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "UserPlus" "lucide-react", createObj !!properties)

    static member inline UserX (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "UserX" "lucide-react", createObj !!properties)

    static member inline User (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "User" "lucide-react", createObj !!properties)

    static member inline Users (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Users" "lucide-react", createObj !!properties)

    static member inline UtensilsCrossed (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "UtensilsCrossed" "lucide-react", createObj !!properties)

    static member inline Utensils (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Utensils" "lucide-react", createObj !!properties)

    static member inline VenetianMask (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "VenetianMask" "lucide-react", createObj !!properties)

    static member inline Verified (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Verified" "lucide-react", createObj !!properties)

    static member inline VibrateOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "VibrateOff" "lucide-react", createObj !!properties)

    static member inline Vibrate (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Vibrate" "lucide-react", createObj !!properties)

    static member inline VideoOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "VideoOff" "lucide-react", createObj !!properties)

    static member inline Video (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Video" "lucide-react", createObj !!properties)

    static member inline View (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "View" "lucide-react", createObj !!properties)

    static member inline Voicemail (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Voicemail" "lucide-react", createObj !!properties)

    static member inline Volume1 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Volume1" "lucide-react", createObj !!properties)

    static member inline Volume2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Volume2" "lucide-react", createObj !!properties)

    static member inline VolumeX (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "VolumeX" "lucide-react", createObj !!properties)

    static member inline Volume (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Volume" "lucide-react", createObj !!properties)

    static member inline Wallet (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Wallet" "lucide-react", createObj !!properties)

    static member inline Wand2 (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Wand2" "lucide-react", createObj !!properties)

    static member inline Wand (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Wand" "lucide-react", createObj !!properties)

    static member inline Watch (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Watch" "lucide-react", createObj !!properties)

    static member inline Waves (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Waves" "lucide-react", createObj !!properties)

    static member inline Webcam (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Webcam" "lucide-react", createObj !!properties)

    static member inline Webhook (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Webhook" "lucide-react", createObj !!properties)

    static member inline WifiOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "WifiOff" "lucide-react", createObj !!properties)

    static member inline Wifi (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Wifi" "lucide-react", createObj !!properties)

    static member inline Wind (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Wind" "lucide-react", createObj !!properties)

    static member inline Wine (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Wine" "lucide-react", createObj !!properties)

    static member inline WrapText (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "WrapText" "lucide-react", createObj !!properties)

    static member inline Wrench (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Wrench" "lucide-react", createObj !!properties)

    static member inline XCircle (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "XCircle" "lucide-react", createObj !!properties)

    static member inline XOctagon (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "XOctagon" "lucide-react", createObj !!properties)

    static member inline XSquare (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "XSquare" "lucide-react", createObj !!properties)

    static member inline X (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "X" "lucide-react", createObj !!properties)

    static member inline Youtube (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Youtube" "lucide-react", createObj !!properties)

    static member inline ZapOff (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ZapOff" "lucide-react", createObj !!properties)

    static member inline Zap (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "Zap" "lucide-react", createObj !!properties)

    static member inline ZoomIn (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ZoomIn" "lucide-react", createObj !!properties)

    static member inline ZoomOut (properties : #ISvgAttribute list) =
        Interop.reactApi.createElement(import "ZoomOut" "lucide-react", createObj !!properties)
